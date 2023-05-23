using ApplicationServices.IServices;
using ApplicationServices.Services;
using BusinessObjects.Models;
using DataAccessLayer;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using KieuMinhHieuWPF.AdminWindows.Customers;
using KieuMinhHieuWPF.AdminWindows.FlowerBouquets;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KieuMinhHieuWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
           
            services.AddServices();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<NewCustomerWindow>();
            services.AddSingleton<UpdateCustomerWindow>();
            services.AddSingleton<FlowerBouquetManagementWindow>();
            services.AddSingleton<CustomerWindow>();
            services.AddSingleton<LoginWindow>();
            services.AddSingleton<AddFlowerBouquetWindow>();
            services.AddSingleton<UpdateFlowerBouquetWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var windowMainWindow = serviceProvider.GetService<FlowerBouquetManagementWindow>();
            windowMainWindow.Show();
            
        }
    }
}
