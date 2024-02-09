using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
   public interface ICategoryRepository:IRepository<Category>
    {
        void Add(Category category);
        IEnumerable<Product> GetProducts(Category category);
    }
}
