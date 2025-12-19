using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCoperation.Services
{
    public class SavingService
    {
        AppDbContext _db;
        public SavingService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Saving?> findById(int id) // search berdasarkan id
        {
            return await _db.Savings.FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<Saving> findByName(String name) // search berdasarkan id
        {
            return _db.Savings.Where(x => x.Member.FullName == name).ToList<Saving>();
        }

        public async Task<List<Saving>> LoadSavingGrid(int memberId)
        {
            return await _db.Savings
                .Where(x => x.MemberId == memberId)
                .OrderByDescending(x => x.CreatedOn).ToListAsync();
        }

        public async Task saveOrUpdate(Member member, string amount, string ktp,
            string kk, string slip, string dueDate, string interest,
            string interestFine, string savingId, string tenor, string adminFee)
        {
            int tenorLeft = int.Parse(tenor);
            decimal decAmount = decimal.Parse(amount);
            decimal decInterest = decimal.Parse(interest);
            decimal outstanding = (decAmount * (decInterest / 100) * tenorLeft) + decAmount;

            Saving l = new Saving
            {
                Amount = decAmount,
                CreatedOn = DateTime.UtcNow,
                DueDate = int.Parse(dueDate),
                Interest = decInterest,
                InterestFine = decimal.Parse(interestFine),
                KkPath = kk,
                KtpPath = ktp,
                SlipGajiPath = slip,
                SavingId = int.Parse(savingId),
                Tenor = tenorLeft,
                MemberId = member.Id,
                AdminFee = decimal.Parse(adminFee),
                TotalAmount = outstanding + decimal.Parse(adminFee)
            };
            _db.Savings.Add(l);
            await _db.SaveChangesAsync();
        }

        /*public object LoadApproval()
        {
            return _db.Savings.Where(x => x.ApprovedOn == null)
                .Include(x => x.Member)
                .OrderByDescending(x => x.CreatedOn)
                .Select(x => new
                {
                    x.Id,
                    MemberData = x.Member.MemberId + " - " + x.Member.FullName,
                    JoinDate = x.Member.JoinDate.ToString("f"),
                    x.SavingId,
                    x.Amount,
                    x.Outstanding,
                    RequestDate = x.CreatedOn.ToString("f"),
                    x.Tenor,
                    x.Interest,
                    Kk = x.KkPath,
                    Ktp = x.KtpPath,
                    Slip = x.SlipGajiPath
                })
                .ToList();
        }*/

        public async Task<List<Saving>> LoadsApproval()
        {
            return await _db.Savings
                .Where(x => x.ApprovedOn == null)
                .Include(x => x.Member)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();
        }

        public async void SetApproval(int id, bool isApprove)
        {
            Saving? l = await _db.Savings.FirstOrDefaultAsync(x => x.Id == id);
            if (l != null)
            {
                l.ApprovedOn = DateTime.UtcNow;
                if (isApprove)
                    l.IsApproved = true;
                else
                    l.IsApproved = false;
                _db.Savings.Update(l);
                await _db.SaveChangesAsync();
            }
        }
        
        public async Task recalculateSaving(int idSaving, string amount)
        {
            decimal payment = decimal.Parse(amount);
            int todaysDate = DateTime.UtcNow.Day;
            Saving? l = await _db.Savings.FirstOrDefaultAsync(x => x.Id == idSaving);
            if (l != null)
            {
                if (todaysDate > l.DueDate)
                {
                    l.Fine = (l.Amount * l.InterestFine) + l.Fine;
                    l.TotalAmount += l.Fine;
                }
                
                l.TotalAmount -= payment;
               
                _db.Savings.Update(l);
                await _db.SaveChangesAsync();
            }
        }
    }
}
