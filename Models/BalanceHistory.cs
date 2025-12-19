using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCoperation.Models
{
    public class BalanceHistory
    {
        String MemberCode { get; set; }
        String Balance { get; set; }
        DateTime UpdateOn { get; set; } = DateTime.UtcNow;
    }
}
