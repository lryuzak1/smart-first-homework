using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> categories = new List<Category>();
        public void Add(Category category)
        {
            categories.Add(category);
            category.id = categories.Count();
        }

        public void Delete(int id)
        {
            var category = categories.FirstOrDefault(x => x.id == id);
            categories.Remove(category);
            foreach (Product p in category.products) {
                p.category = null;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return categories;
        }

        public Category GetByID(int id)
        {
            return categories.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Product> GetProducts(Category category)
        {
            return category.products;          
        }
    }
}
