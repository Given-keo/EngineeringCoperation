using BraveHeroCooperation.Data;
using BraveHeroCooperation.Models;
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
    public class AccessService
    {
        private readonly AppDbContext _db;
        public AccessService(AppDbContext db) => _db = db;

        public async Task<Access?> GetAccess(int memberId)
        {
            var access = await _db.Accesses.FirstOrDefaultAsync(
                x => x.MemberId == memberId);
            return access;
        }

        public object setGridView()
        {
            var grid = _db.Accesses.OrderBy(x => x.MemberId)
                .Select(x => new
                {
                    x.Id,
                    DisplayMember = x.Member.MemberId + " - " + x.Member.FullName,
                    x.AccessList,
                    x.UpdateOn
                }).ToList();
            return grid;
        }

        public Access? findByMember(int id)
        {
            return _db.Accesses.FirstOrDefault(x => x.MemberId == id);
        }

        public async Task update(Access access, string accessList)
        {
            access.AccessList = accessList;
            access.UpdateOn = DateTime.UtcNow;
            _db.Update(access);
            await _db.SaveChangesAsync();
        }

        public async Task newOne(Access? access, Member member, string accessList)
        {
            var a = new Access
            {
                Member = member,
                AccessList = accessList,
                MemberId = member.Id,
                UpdateOn = DateTime.UtcNow
            };
            _db.Add(a);
            await _db.SaveChangesAsync();
        }

        public Access? findById(int id)
        {
            return _db.Accesses.FirstOrDefault(x => x.Id == id);
        }
    }
}
