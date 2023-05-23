using ApplicationServices.IServices;
using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SupplierService(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }
        public List<Supplier> GetAllSuppliers()
        {
            return _unitOfWork.SupplierRepository.GetAll();
        }
    }
}
