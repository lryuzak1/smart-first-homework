using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public interface ICategoryService
    {
        void Add(Category category);
        IEnumerable<Product> GetProducts(Category category);
        void Delete(int id);
        Category GetByID(int id);
        IEnumerable<Category> GetAll();
    }
}
