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
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISupplierRepository _supplierRepository;
        public UnitOfWork(
            FUFlowerBouquetManagementContext context, 
            ICustomerRepository customerRepository, 
            IFlowerBouquetRepository flowerBouquetRepository,
            ICategoryRepository categoryRepository,
            ISupplierRepository supplierRepository)
        {
            _context = context;
            _customerRepository = customerRepository;
            _flowerBouquetRepository = flowerBouquetRepository;
            _categoryRepository = categoryRepository;
            _supplierRepository = supplierRepository;
        }

        public ICustomerRepository CustomerRepository => _customerRepository;

        public IFlowerBouquetRepository FlowerBouquetRepository => _flowerBouquetRepository;
        public ICategoryRepository CategoryRepository => _categoryRepository;
        public ISupplierRepository SupplierRepository => _supplierRepository;
        public bool SaveChange()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
