using ApplicationServices.IServices;
using BusinessObjects.Models;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KieuMinhHieuWPF.AdminWindows.Customers
{
    /// <summary>
    /// Interaction logic for NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        private readonly ICustomerService _customerService;
        private readonly IServiceProvider _serviceProvider;
        public NewCustomerWindow(ICustomerService customerService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerService = customerService;
            _serviceProvider = serviceProvider;
        }

        private CustomerNewModel GetModel()
        {
            return new CustomerNewModel
            {
                Email = txtEmail.Text,
                CustomerName = txtName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Password,
                ConfimPassword=txtConfirmPassword.Password,
                Birthday = DateTime.Parse(dtBirthday.Text.ToString())
            };
        }

        private void ResetAllValue()
        {
            txtEmail.Text=string.Empty;
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Password = string.Empty;
            txtConfirmPassword.Password = string.Empty;
            dtBirthday.Text = null;
        }

        private void BtnSaveInfor(object sender, RoutedEventArgs e)
        {
            try
            {
                var customer= GetModel();
                if (customer.Password != customer.ConfimPassword)
                {
                    MessageBox.Show("Confirm Password is not match!");
                    return;
                }
                var result = _customerService.AddCustomer(customer);
                if (result)
                {
                    ResetAllValue();
                    _serviceProvider.GetRequiredService<CustomerWindow>().LoadCustomer();
                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            this.Visibility= Visibility.Collapsed;
        }
    }
}
