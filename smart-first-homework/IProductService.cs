using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public interface IProductService
    {
        void Add(Product item, Category category);
        void MakeDiscount(int percernt, Product product);
        void RestorePrice(Product product);
        void Delete(int id);
        Product GetByID(int id);
        IEnumerable<Product> GetAll();
    }
}
