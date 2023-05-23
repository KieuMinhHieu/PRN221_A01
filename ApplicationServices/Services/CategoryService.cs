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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
        public List<Category> GetALlCategories()
        {
          return _unitOfWork.CategoryRepository.GetAll();
        }
    }
}
