using BusinessObjects.Models;
using DTOs.CustomerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.IServices
{
    public interface ICustomerService
    {
        bool AddCustomer(CustomerNewModel customer);
        bool UpdateCustomer(CustomerInforModel customer);
        bool DeleteCustomer(int customerId);
        Customer GetCustomerById(int customerId);
        List<CustomerInforModel> GetAllCustomers();
        
        Customer GetCustomerByEmail(string email);

        Customer FindCustomer(params string[] paramStrings);
    }
}
