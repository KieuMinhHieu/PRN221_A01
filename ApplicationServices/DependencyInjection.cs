using ApplicationServices.IServices;
using ApplicationServices.Mappers;
using ApplicationServices.Services;
using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        { 
            #region Add Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IFlowerBouquetRepository, FlowerBouquetRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IFlowerBouquetService, FlowerBouquetService>();

            services.AddScoped<ISupplierRepository,SupplierRepository>();
            services.AddScoped<ISupplierService, SupplierService>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddSingleton(typeof(FUFlowerBouquetManagementContext));
            #endregion

            services.AddAutoMapper(typeof(MapperConfigurationsProfile).Assembly);

            return services;
        }
    }
}
