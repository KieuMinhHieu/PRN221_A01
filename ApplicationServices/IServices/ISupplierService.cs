using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.IServices
{
    public interface ISupplierService
    {
        public List<Supplier> GetAllSuppliers();
    }
}
