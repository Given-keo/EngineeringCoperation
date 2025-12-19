using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCoperation.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public String MemberCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime UpdateOn { get; set; }
        public string TransactionName {  get; set; }
        public string Flow { get; set; }
    }
}
