using BusinessObjects.Models;
using DTOs.FlowerBouquetViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.IServices
{
    public interface IFlowerBouquetService
    {
        bool AddFlowerBouquet(FlowerBouquetNewModel flowerBouquetNew);
        bool UpdateFlowerBouquet(FlowerBouquetUpdateModel flowerBouquetUpdate);

        bool DeleteFlowerBouquet(int FlowerBouquetId);

        FlowerBouquet GetFlowerBouquetById(int FlowerBouquetId);

        List<FlowerBouquetViewModel> GetAllFlowerBouquets();

        void SaveDataInCache(FlowerBouquetUpdateModel flowerBouquetUpdate);

        FlowerBouquetUpdateModel GetDataInCache();
    }
}
