using ApplicationServices.IServices;
using DTOs.CustomerViewModels;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KieuMinhHieuWPF.AdminWindows.Customers
{
    /// <summary>
    /// Interaction logic for UpdateCustomerWindow.xaml
    /// </summary>
    public partial class UpdateCustomerWindow : Window
    {
        private readonly ICustomerService _customerService;
        private readonly IServiceProvider _serviceProvider;
        public UpdateCustomerWindow(ICustomerService customerService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerService = customerService;
            _serviceProvider = serviceProvider;
            ResetValue();
        }

        public void LoadInfor(CustomerInforModel customerInforModel)
        {
            txtId.Text=customerInforModel.CustomerId.ToString();
            txtEmail.Text = customerInforModel.Email;
            txtName.Text = customerInforModel.CustomerName;
            txtCity.Text = customerInforModel.City;
            txtCountry.Text = customerInforModel.Country;
            txtPassword.Password = customerInforModel.Password;
            dtBirthday.Text = customerInforModel.Birthday.ToString();
        }

        public CustomerInforModel? GetValue()
        {

            return new CustomerInforModel
            {
                CustomerId=int.Parse( txtId.Text),
                Email = txtEmail.Text,
                CustomerName = txtName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Password,
                Birthday = DateTime.Parse(dtBirthday.Text.ToString())
            };
        }

        public void ResetValue()
        {
            txtId.Text = "0";
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Password = string.Empty;
            dtBirthday.Text = DateTime.Now.ToString();
        }
        private void BtnUpdateInfor(object sender, RoutedEventArgs e)
        {
            try
            {
                var customerUpdate= GetValue();

                MessageBoxResult confrim = MessageBox.Show("Are you sure you want to Updated?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (confrim == MessageBoxResult.Yes)
                {
                    var result = _customerService.UpdateCustomer(customerUpdate);
                    if (result)
                    {
                        ResetValue();
                        this.Hide();
                        _serviceProvider.GetRequiredService<CustomerWindow>().LoadCustomer();
                    }
                }
                   
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            this.Visibility=Visibility.Hidden;
        }
    }
}
