using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) 
        {
            this.categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            categoryRepository.Add(category);
        }

        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category GetByID(int id)
        {
            return categoryRepository.GetByID(id);
        }

        public IEnumerable<Product> GetProducts(Category category)
        {
            return categoryRepository.GetProducts(category);
        }
    }
}
