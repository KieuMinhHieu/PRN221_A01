using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface IUnitOfWork
    {
        public IFlowerBouquetRepository FlowerBouquetRepository { get; }
        public ICustomerRepository CustomerRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public ISupplierRepository SupplierRepository { get; }
        public bool SaveChange();
    }
}
