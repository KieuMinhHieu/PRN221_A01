using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.FlowerBouquetViewModels
{
    public class FlowerBouquetViewModel
    {
        public int FlowerBouquetId { get; set; }
        public string CategoryName { get; set; }
        public string FlowerBouquetName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool? FlowerBouquetStatus { get; set; }
        public string? SupplierName { get; set; }
    }
}
