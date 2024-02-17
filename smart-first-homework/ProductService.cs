using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class ProductService :  IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Add(Product item, Category category)
        {
            productRepository.Add(item, category);
        }

        public void Delete(int id)
        {
            productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public Product GetByID(int id)
        {
            return productRepository.GetByID(id);
        }

        public void makeDiscount(int percernt, Product product)
        {
            productRepository.makeDiscount(percernt, product);
        }

        public void restorePrice(Product product)
        {
            productRepository.restorePrice(product);
        }
    }
}
