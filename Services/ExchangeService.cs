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
    public class ExchangeService
    {
        private readonly AppDbContext _db;
        public ExchangeService(AppDbContext db) => _db = db;

        public async void save(Exchange exchange)
        {
            _db.Exchanges.Add(exchange);
            await _db.SaveChangesAsync();
        }

        public async Task<Exchange?> getExchange(String exchangeId)
        {
            return await _db.Exchanges.FirstOrDefaultAsync(b => b.ExchangeId == exchangeId);
        }

        public async void Update(Exchange exchange)
        {
            _db.Exchanges.Update(exchange);
            await _db.SaveChangesAsync();
        }
    }
}
