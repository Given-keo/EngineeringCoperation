using System.ComponentModel.DataAnnotations;

namespace EngineeringCoperation.Models
{
    public class Configuration
    {
        public int Id { get; set; }
        [MaxLength(4000)] public string terminologi1 { get; set; }
        [MaxLength(4000)] public string terminologi2 { get; set; }
        [MaxLength(4000)] public string terminologi3 { get; set; }
        public decimal exchangeRate { get; set; }
        public decimal transferAcrossFee { get; set; }
        public decimal transferInhouseFee { get; set; }
    }
}
