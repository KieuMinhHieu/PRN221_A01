using ApplicationServices.IServices;
using AutoMapper;
using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using DTOs.FlowerBouquetViewModels;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class FlowerBouquetService : IFlowerBouquetService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;

        public FlowerBouquetService(IUnitOfWork unitOfWork,IMapper mapper,IMemoryCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public bool AddFlowerBouquet(FlowerBouquetNewModel flowerBouquetNew)
        {
            var mapper = _mapper.Map<FlowerBouquet>(flowerBouquetNew);
            mapper.FlowerBouquetId = _unitOfWork.FlowerBouquetRepository.GetAll().Max(x => x.FlowerBouquetId)+1;
            _unitOfWork.FlowerBouquetRepository.Add(mapper);
            var result = _unitOfWork.SaveChange();
            return result;
        }

        public bool DeleteFlowerBouquet(int flowerBouquetId)
        {
            bool result = false;
            var flowerBouquet = _unitOfWork.FlowerBouquetRepository.FindByField(x => x.FlowerBouquetId == flowerBouquetId,x=>x.OrderDetails);
            if (flowerBouquet.OrderDetails.Count > 0)
            {
                flowerBouquet.FlowerBouquetStatus = 0;
                _unitOfWork.FlowerBouquetRepository.Update(flowerBouquet);
                result=_unitOfWork.SaveChange();
                _unitOfWork.FlowerBouquetRepository.Detached(x => x.FlowerBouquetId == flowerBouquetId);

            }
            else
            {
                _unitOfWork.FlowerBouquetRepository.Delete(flowerBouquet);
              result=  _unitOfWork.SaveChange();
            }
            return result;
        }

        public List<FlowerBouquetViewModel> GetAllFlowerBouquets()
        {
            var flowerBouquet= _unitOfWork.FlowerBouquetRepository.GetAll(x=>x.Category,x=>x.Supplier);
            var mapper=_mapper.Map<List<FlowerBouquetViewModel>>(flowerBouquet);
            return mapper;
        }

        public FlowerBouquet GetFlowerBouquetById(int FlowerBouquetId)
        {
            throw new NotImplementedException();
        }

        public void SaveDataInCache(FlowerBouquetUpdateModel flowerBouquetUpdate)
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(10),
                Priority = CacheItemPriority.Normal,
                SlidingExpiration = TimeSpan.FromMinutes(5),
                Size = 100,
            };
            _cache.Set("flowerBouquetUpdate", flowerBouquetUpdate,cacheExpiryOptions);
        }

        private FlowerBouquetUpdateModel GetDataInCache()
        {
            _ = _cache.TryGetValue("flowerBouquetUpdate", out FlowerBouquetUpdateModel flowerBouquetUpdate);
            return flowerBouquetUpdate;
        }

        public bool UpdateFlowerBouquet(FlowerBouquetUpdateModel flowerBouquetUpdate)
        {
            var mapper = _mapper.Map<FlowerBouquet>(flowerBouquetUpdate);
            _unitOfWork.FlowerBouquetRepository.Update(mapper);
            var result = _unitOfWork.SaveChange();
            _unitOfWork.FlowerBouquetRepository.Detached(x=>x.FlowerBouquetId==flowerBouquetUpdate.FlowerBouquetId); 
            return result;
        }

       
    }
}
