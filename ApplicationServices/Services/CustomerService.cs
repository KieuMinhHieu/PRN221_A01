using ApplicationServices.IServices;
using AutoMapper;
using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using DTOs.CustomerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public bool AddCustomer(CustomerNewModel customerNewModel)
        {
            var customer=_mapper.Map<Customer>(customerNewModel);
            customer.CustomerId= _unitOfWork.CustomerRepository.GetAll().Max(x => x.CustomerId) + 1;
            _unitOfWork.CustomerRepository.Add(customer);
            var result=_unitOfWork.SaveChange();
            return result;
        }

        public bool DeleteCustomer(int customerId)
        {
            var customer = _unitOfWork.CustomerRepository.FindByField(x => x.CustomerId==customerId);
            _unitOfWork.CustomerRepository.Delete(customer);
            var result=_unitOfWork.SaveChange() ;
            return result;
        }

        public Customer FindCustomer(params string[] paramStrings)
        {
            throw new NotImplementedException();
        }

        public List<CustomerInforModel> GetAllCustomers()
        {
            var customer= _unitOfWork.CustomerRepository.GetAll(c => c.Orders);
            var result=_mapper.Map<List<CustomerInforModel>>(customer);
            return result;
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByEmail(string email)
        {
            var customer=_unitOfWork.CustomerRepository.FindByField(x=>x.Email==email);
            return customer;
        }

        public bool UpdateCustomer(CustomerInforModel customerÌnfor)
        {
            var customerMapper = _mapper.Map<Customer>(customerÌnfor);
            _unitOfWork.CustomerRepository.Update(customerMapper);
            var result =_unitOfWork.SaveChange() ;
            return result;  
        }
    }
}
