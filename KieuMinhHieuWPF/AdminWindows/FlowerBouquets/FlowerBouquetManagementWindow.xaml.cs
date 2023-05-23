using ApplicationServices.IServices;
using ApplicationServices.Services;
using DTOs.CustomerViewModels;
using DTOs.FlowerBouquetViewModels;
using KieuMinhHieuWPF.AdminWindows.Customers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KieuMinhHieuWPF.AdminWindows.FlowerBouquets
{
    /// <summary>
    /// Interaction logic for FlowerBouquetManagementWindow.xaml
    /// </summary>
    public partial class FlowerBouquetManagementWindow : Window
    {
        private readonly IFlowerBouquetService _flowerBouquetService;
        private readonly IServiceProvider _serviceProvider;
        public FlowerBouquetManagementWindow(IFlowerBouquetService flowerBouquetService,IServiceProvider serviceProvider )
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _flowerBouquetService = flowerBouquetService;
            LoadFlowerBouquet();
        }

        private void BtnNewCustomer(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<AddFlowerBouquetWindow>().Show();
        }

        private void BtnUpdateCustomer(object sender, RoutedEventArgs e)
        {
            var data = GetSelectedValue();
            var service = _serviceProvider.GetRequiredService<UpdateFlowerBouquetWindow>();
            if (data != null )
            {
                if(service.GetInputValue().FlowerBouquetId!= data.FlowerBouquetId)
                {
                    service.LoadUpdateData(data);
                }
                service.Show(); 
            }
           
           
        }

        private void BtnDeleteCustomer(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = GetSelectedValue();
                if (data != null)
                {
                    MessageBoxResult confrim = MessageBox.Show("Are you sure you want to deleted?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (confrim == MessageBoxResult.Yes)
                    {
                        var result = _flowerBouquetService.DeleteFlowerBouquet(data.FlowerBouquetId);

                        if (result)
                        {
                            LoadFlowerBouquet();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchChanged(object sender, TextChangedEventArgs e)
        {
            var value = txtSearch.Text.ToString();
            if (value is null)
            {
                LoadFlowerBouquet();
            }
            else
            {
                var customerSearchs = GetAllFlowerBouquets()
                    .Where(x => x.FlowerBouquetName.Contains(value) ||
                              x.CategoryName.Contains(value) ||
                              x.SupplierName.Contains(value))
                    .ToList();
                dgvFlowerBouquet.ItemsSource = customerSearchs;
            }
        }

        private FlowerBouquetViewModel GetSelectedValue()
        {

            try
            {
                FlowerBouquetViewModel data;
                if (dgvFlowerBouquet.SelectedItem != null)
                {
                    data = (FlowerBouquetViewModel)dgvFlowerBouquet.SelectedItem;
                    return data;
                }
                else
                {
                    MessageBox.Show("Please! Select item first!");
                }

            }
            catch (InvalidCastException iex)
            {
                MessageBox.Show("Item is not exit! Please try again!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void BtnLogout(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<LoginWindow>().Show();
            this.Hide();
        }
        private void BtnCustomertManagement(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<CustomerWindow>().Show();
            this.Hide();
        }
        private void BtnOderManagement(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<FlowerBouquetManagementWindow>().Show();
            this.Hide();
        }

        public List<FlowerBouquetViewModel> GetAllFlowerBouquets()
        {
            var flowerBouquetInfor= _flowerBouquetService.GetAllFlowerBouquets();
            return flowerBouquetInfor;
        }

        public void LoadFlowerBouquet()
        {

            dgvFlowerBouquet.ItemsSource = GetAllFlowerBouquets();
        }
    }
}
