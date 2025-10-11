using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EngineeringCoperation.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required, MaxLength(100)] public string Username { get; set; }
        [Required] public string PasswordHash { get; set; } = "";
        [Required, MaxLength(200)] public string fullName { get; set; } = "";
        public bool IsActive { get; set; } = true;
        public DateTime JoinDate { get; set; } = DateTime.UtcNow;
        public string MemberId { get; set; }
        public string IdCard { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }
        public string PhoneAlt { get; set; }
        public string Email { get; set; }
        public DateTime ModDate { get; set; } 
        public string Status { get; set; }
        public string ReferenceId { get; set; }
        public string level { get; set; }



        [Required, MaxLength(4000)] public string Question1 { get; set; } = null!;
        [Required, MaxLength(4000)] public string Question2 { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>()
    }
}
