using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;

namespace EngineeringCoperation.Services
{
    public class ExchangeService
    {
        private readonly AppDbContext _db;

        public ExchangeService(AppDbContext db) => _db = db;

        public async void save(Exchange exchange) {
            _db.Exchanges.Add(exchange);
            await _db.SaveChangesAsync();  
        }
    }
}
