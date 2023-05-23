using AutoMapper;
using BusinessObjects.Models;
using DTOs.CustomerViewModels;
using DTOs.FlowerBouquetViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Mappers
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            CreateMap<CustomerInforModel, Customer>()
                .ForMember(dest => dest.CustomerId, src => src.MapFrom(x => x.CustomerId))
                .ForMember(dest => dest.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.CustomerName, src => src.MapFrom(x => x.CustomerName))
                .ForMember(dest => dest.City, src => src.MapFrom(x => x.City))
                .ForMember(dest => dest.Country, src => src.MapFrom(x => x.Country))
                .ForMember(dest => dest.Password, src => src.MapFrom(x => x.Password))
                .ForMember(dest => dest.Birthday, src => src.MapFrom(x => x.Birthday))
                .ForPath(dest => dest.Orders.Count, src => src.MapFrom(x => x.NumOfOrders))
                .ReverseMap();

            CreateMap<CustomerNewModel, Customer>()
              .ForMember(dest => dest.Email, src => src.MapFrom(x => x.Email))
              .ForMember(dest => dest.CustomerName, src => src.MapFrom(x => x.CustomerName))
              .ForMember(dest => dest.City, src => src.MapFrom(x => x.City))
              .ForMember(dest => dest.Country, src => src.MapFrom(x => x.Country))
              .ForMember(dest => dest.Password, src => src.MapFrom(x => x.Password))
              .ForMember(dest => dest.Birthday, src => src.MapFrom(x => x.Birthday))
              .ReverseMap();


            CreateMap<FlowerBouquetViewModel, FlowerBouquet>()
                .ForMember(dest => dest.FlowerBouquetId, src => src.MapFrom(x => x.FlowerBouquetId))
              .ForMember(dest => dest.FlowerBouquetName, src => src.MapFrom(x => x.FlowerBouquetName))
              .ForMember(dest => dest.Description, src => src.MapFrom(x => x.Description))
              .ForMember(dest => dest.UnitPrice, src => src.MapFrom(x => x.UnitPrice))
              .ForMember(dest => dest.UnitsInStock, src => src.MapFrom(x => x.UnitsInStock))
              .ForPath(dest => dest.Supplier.SupplierName, src => src.MapFrom(x => x.SupplierName))
              .ForPath(dest => dest.Category.CategoryName, src => src.MapFrom(x => x.CategoryName))
              .ReverseMap();

            CreateMap<FlowerBouquetNewModel, FlowerBouquet>()
               .ForMember(dest => dest.CategoryId, src => src.MapFrom(x => x.CategoryId))
             .ForMember(dest => dest.FlowerBouquetName, src => src.MapFrom(x => x.FlowerBouquetName))
             .ForMember(dest => dest.Description, src => src.MapFrom(x => x.Description))
             .ForMember(dest => dest.UnitPrice, src => src.MapFrom(x => x.UnitPrice))
             .ForMember(dest => dest.UnitsInStock, src => src.MapFrom(x => x.UnitsInStock))
             .ForMember(dest => dest.FlowerBouquetStatus, src => src.MapFrom(x => x.FlowerBouquetStatus))
             .ForMember(dest => dest.SupplierId, src => src.MapFrom(x => x.SupplierId))
             .ReverseMap();

            CreateMap<FlowerBouquetUpdateModel, FlowerBouquet>()
           .ForMember(dest => dest.FlowerBouquetId, src => src.MapFrom(x => x.FlowerBouquetId)) 
           .ForMember(dest => dest.CategoryId, src => src.MapFrom(x => x.CategoryId))
           .ForMember(dest => dest.FlowerBouquetName, src => src.MapFrom(x => x.FlowerBouquetName))
           .ForMember(dest => dest.Description, src => src.MapFrom(x => x.Description))
           .ForMember(dest => dest.UnitPrice, src => src.MapFrom(x => x.UnitPrice))
           .ForMember(dest => dest.UnitsInStock, src => src.MapFrom(x => x.UnitsInStock))
           .ForMember(dest => dest.FlowerBouquetStatus, src => src.MapFrom(x => x.FlowerBouquetStatus))
           .ForMember(dest => dest.SupplierId, src => src.MapFrom(x => x.SupplierId))
           .ReverseMap();

        }
    }
}
