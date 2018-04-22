using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Data.Repositories;
using BasicWMS.Model;
using BasicWMS.Service.Interfaces;

namespace BasicWMS.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = _categoryRepository.GetAll();
            _unitOfWork.Commit();
            return categories;
        }

        public Category GetCategory(int id)
        {
            var category = _categoryRepository.GetById(id);
            _unitOfWork.Commit();
            return category;
        }

        public Category GetCategory(string name)
        {
            var category = _categoryRepository.GetByName(name);
            _unitOfWork.Commit();
            return category;
        }

        public void CreateCategory(Category category)
        {
            _categoryRepository.Add(category);
            _unitOfWork.Commit();
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
            _unitOfWork.Commit();
        }

        public void DeleteCategory(Category category)
        {
            _categoryRepository.Delete(category);
            _unitOfWork.Commit();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _categoryRepository.GetProductsByCategory(categoryId);
        }
    }
}
