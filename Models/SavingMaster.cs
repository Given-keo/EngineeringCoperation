using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCoperation.Models
{
    public class SavingMaster
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Interest { get; set; }
        public decimal Fine { get; set; }
        public decimal AdminFee { get; set; }
        public decimal MinAmount { get; set; } = 0;
        public decimal MaxAmount { get; set; } = 0;
        public int Tenor { get; set; }
        public DateTime updateOn { get; set; }
    }
}
