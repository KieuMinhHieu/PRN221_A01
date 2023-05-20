using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FUFlowerBouquetManagementContext _context;
        private readonly ICustomerRepository _customerRepository;
        private readonly IFlowerBouquetRepository _flowerBouquetRepository;
        public UnitOfWork(FUFlowerBouquetManagementContext context, ICustomerRepository customerRepository, IFlowerBouquetRepository flowerBouquetRepository)
        {
            _context = context;
            _customerRepository = customerRepository;
            _flowerBouquetRepository = flowerBouquetRepository;
        }

        public ICustomerRepository CustomerRepository => _customerRepository;

        public IFlowerBouquetRepository FlowerBouquetRepository => _flowerBouquetRepository;

        public bool SaveChangeAsync()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
