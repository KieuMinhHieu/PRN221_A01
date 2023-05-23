using ApplicationServices.Commons;
using ApplicationServices.IServices;
using BusinessObjects.Models;
using DTOs.CustomerViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KieuMinhHieuWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly ICustomerService _customerService;
        private readonly IServiceProvider _serviceProvider;
        private readonly string _adminAccount;
        private readonly string _adminPassword;
        public LoginWindow(ICustomerService customerService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerService = customerService;
            _serviceProvider = serviceProvider;
            _adminAccount = GetString.GetStringJson("EmailAdmin");
            _adminPassword = GetString.GetStringJson("PasswordAdmin");
        }

        private Customer IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email) )
            {
                txtErrormessage.Text = "Please! Input email";
                txtEmail.Focus();
            }
            var customer = _customerService.GetCustomerByEmail(email);

            if (customer!=null)
            {
                return customer;
            }
            txtEmail.Text = "";
            txtPassword.Password = "";
            txtErrormessage.Text = "Email is not exist!";
            return null;
        }


        private bool IsAdminAccount(LoginModel login)
        {

            if (login.Email.Equals(_adminAccount))
            {
                if (login.Password.Equals(_adminPassword))
                {
                    return true;
                }
                else
                {
                    txtPassword.Password = "";
                    MessageBox.Show("Incorrect Password!");
                }
            }
            
            return false;
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginModel loginModel = new LoginModel {
                    Email = txtEmail.Text,
                    Password = txtPassword.Password
                };
                

                if(IsAdminAccount(loginModel))
                {
                    _serviceProvider.GetRequiredService<CustomerWindow>().Show();
                    this.Hide();
                }
                var customer = IsValidEmail(loginModel.Email);
                if (customer!=null)
                {                   
                    if(customer.Password==loginModel.Password)
                    {
                        
                    }
                    else
                    {
                        txtPassword.Password = "";
                        txtErrormessage.Text = "Password is incorrect!";
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
