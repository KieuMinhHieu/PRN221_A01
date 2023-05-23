using ApplicationServices.IServices;
using DTOs.CustomerViewModels;
using KieuMinhHieuWPF.AdminWindows.FlowerBouquets;
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

namespace KieuMinhHieuWPF.AdminWindows.Customers
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly ICustomerService _customerService;
        private readonly IServiceProvider _serviceProvider;
        public CustomerWindow(ICustomerService customerService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadCustomer();
            _serviceProvider = serviceProvider;
        }

        public void LoadCustomer()
        {
            
            dgvCustomer.ItemsSource = GetAllCustomer();
        }

        private List<CustomerInforModel> GetAllCustomer()
        {
            var customers = _customerService.GetAllCustomers();
            return customers;
        }


        private void BtnLogout(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<LoginWindow>().Show();
            this.Hide();
        }

        private void TxtSearchChanged(object sender, TextChangedEventArgs e)
        {
            var value = txtSearch.Text.ToString();
            if(value is null)
            {
                LoadCustomer();
            }
            else
            {
                var customerSearchs= GetAllCustomer()
                    .Where(x=>x.CustomerName.Contains(value) || 
                              x.Email.Contains(value) ||
                              x.Country.Contains(value)||
                              x.City.Contains(value))
                    .ToList();
                dgvCustomer.ItemsSource = customerSearchs;
            }
        }

        private void BtnNewCustomer(object sender, RoutedEventArgs e)
        {
            //new NewCustomerWindow(_customerService).Show();
             _serviceProvider.GetRequiredService<NewCustomerWindow>().Show();
        }

        private void BtnUpdateCustomer(object sender, RoutedEventArgs e)
        {
            var data=GetSelectedValue();
            if (data != null)
            {
                var service = _serviceProvider.GetRequiredService<UpdateCustomerWindow>();
                if (service.GetValue().CustomerId != data.CustomerId)
                {
                    service.LoadInfor(data);
                }
                service.Show();
            }
           
        }

        private CustomerInforModel GetSelectedValue()
        {
            
            try
            {
                CustomerInforModel data;
                if (dgvCustomer.SelectedItem != null)
                {
                    data = (CustomerInforModel)dgvCustomer.SelectedItem;
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
                        var result = _customerService.DeleteCustomer(data.CustomerId);

                        if (result)
                        {
                            LoadCustomer();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnFlowerBouquetManagement(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<FlowerBouquetManagementWindow>().Show();
            this.Hide();
        }
        private void BtnOderManagement(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<FlowerBouquetManagementWindow>().Show();
            this.Hide();
        }
    }
}
