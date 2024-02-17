using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(int id, IProductRepository productRepository)
        {
            _categoryRepository.Delete(id,productRepository);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByID(int id)
        {
            return _categoryRepository.GetByID(id);
        }

        public IEnumerable<Product> GetProducts(Category category)
        {
            return _categoryRepository.GetProducts(category);
        }
    }
}
