using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> Categories = new List<Category>();
        public void Add(Category category)
        {
            Categories.Add(category);
            category.Id = Categories.Count();
        }

        public void Delete(int id, IProductRepository productRepository)
        {
            var category = Categories.FirstOrDefault(x => x.Id == id);
            Categories.Remove(category);
            foreach (Product p in category.Products) {
                //aq deletes ver viyeneb  da axali metodi davwere magistvis(mxolod repos listidan rom amoshalos
                //da konkretuli produqtis kategoriis obieqtshi ar dauwyos washla torem foreachs ushlis xels rogorc mivxvdi)
                productRepository.RemoveFromList(p.Id);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return Categories;
        }

        public Category GetByID(int id)
        {
            return Categories.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(Category category)
        {
            return category.Products;          
        }
    }
}
