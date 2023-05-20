using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.IServices
{
    public interface IFlowerBouquetService
    {
        FlowerBouquet AddFlowerBouquet(FlowerBouquet flowerBouquet);
        bool UpdateFlowerBouquet(FlowerBouquet flowerBouquet);

        bool DeleteFlowerBouquet(int FlowerBouquetId);

        FlowerBouquet GetFlowerBouquetById(int FlowerBouquetId);

        List<FlowerBouquet> GetAllFlowerBouquets();
    }
}
