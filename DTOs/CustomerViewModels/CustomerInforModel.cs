using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.CustomerViewModels
{
    public class CustomerInforModel
    {
        public int CustomerId { get; set; }
        public string Email { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public int NumOfOrders { get; set; }
    }
}
