using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.FlowerBouquetViewModels
{
    public class FlowerBouquetUpdateModel
    {
        public int FlowerBouquetId { get; set; }
        public int CategoryId { get; set; }
        public string FlowerBouquetName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool? FlowerBouquetStatus { get; set; }
        public int? SupplierId { get; set; }
    }
}
