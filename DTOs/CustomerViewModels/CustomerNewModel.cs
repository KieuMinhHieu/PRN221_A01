using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.CustomerViewModels
{
    public class CustomerNewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string CustomerName { get; set; }
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfimPassword { get; set; } 
        public DateTime? Birthday { get; set; }
    }
}
