
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Services
{
    public class ProductService
    {
        private readonly AppDbContext db;

        public ProductService(AppDbContext db)
        {
            this.db = db;
        }

        public List<LoanMaster> LoadLoanGrid()
        {
            return db.LoanMasters.OrderByDescending(x => x.updateOn).ToList();
        }

        public List<SavingMaster> LoadSavingGrid()
        {
            return db.SavingMasters.OrderByDescending(x => x.updateOn).ToList();
        }

        public async Task SaveOrUpdateLoan(string id, string name, string minfine, string maxfine, string interest)
        {
            if (string.IsNullOrEmpty(id))
            {
                LoanMaster loan = new LoanMaster
                {
                    Name = name,
                    //MinFine = Convert.ToDecimal(minfine),
                    //MaxFine = Convert.ToDecimal(maxfine),
                    Interest = Convert.ToDecimal(interest),
                    //UpdateOn = DateTime.Now
                };
                db.LoanMasters.Add(loan);
            }
            else
            {
                var loan = db.LoanMasters.Find(Convert.ToInt32(id.Trim()));
                loan.Name = name;
                //loan.MinFine = Convert.ToDecimal(minfine);
                //loan.MaxFine = Convert.ToDecimal(maxfine);
                loan.Interest = Convert.ToDecimal(interest);
                //loan.UpdateOn = DateTime.Now;
                db.LoanMasters.Update(loan);
            }
            await db.SaveChangesAsync();
        }

        public async Task SaveOrUpdateSaving(string id, string name, string minfine, string maxfine, string interest)
        {
            if (string.IsNullOrEmpty(id))
            {
                SavingMaster saving = new SavingMaster
                {
                    Name = name,
                    //MinFine = Convert.ToDecimal(minfine),
                    //MaxFine = Convert.ToDecimal(maxfine),
                    Interest = Convert.ToDecimal(interest),
                    //UpdateOn = DateTime.Now
                };
                db.SavingMasters.Add(saving);
            }
            else
            {
                var saving = db.SavingMasters.Find(Convert.ToInt32(id.Trim()));
                saving.Name = name;
                //saving.MinFine = Convert.ToDecimal(minfine);
                //saving.MaxFine = Convert.ToDecimal(maxfine);
                saving.Interest = Convert.ToDecimal(interest);
                //saving.UpdateOn = DateTime.Now;
                db.SavingMasters.Update(saving);
            }
            await db.SaveChangesAsync();
        }

        public async Task<string> DeleteLoan(string id)
        {
            var loan = db.LoanMasters.Find(Convert.ToInt32(id.Trim()));
            db.LoanMasters.Remove(loan);
            await db.SaveChangesAsync();
            return "done";
        }

        public async Task<string> DeleteSaving(string id)
        {
            var saving = db.SavingMasters.Find(Convert.ToInt32(id.Trim()));
            db.SavingMasters.Remove(saving);
            await db.SaveChangesAsync();
            return "done";
        }

        public List<object> GetLoanSavingList()
        {
            List<object> result = new List<object>();

            var loan = db.LoanMasters.OrderBy(x => x.Name);
            foreach (var item in loan)
            {
                result.Add(new
                {
                    id = item.id,
                    displayName = $"{item.Name} - {item.Interest} %",
                    type = "Loan"
                });
            }

            var saving = db.SavingMasters.OrderBy(x => x.Name);
            foreach (var item in saving)
            {
                result.Add(new
                {
                    id = item.id,
                    displayName = $"{item.Name} - {item.Interest} %",
                    type = "Saving"
                });
            }

            result.Add(new { id = 0, displayName = "-- choose --" });
            return result;
        }
    }
}