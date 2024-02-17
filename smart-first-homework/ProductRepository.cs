using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        public void Add(Product item,Category category)
        {
            products.Add(item);
            category.products.Add(item);
            item.id = products.Count();
        }

        public void Delete(int id)
        {
            Product product = products.FirstOrDefault(x => x.id == id);
            
            products.Remove(product);

            product.category.products.Remove(product);    
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product GetByID(int id)
        {
            return products.FirstOrDefault(x => x.id == id); 
        }

        public void MakeDiscount(int percernt, Product product)
        {
            product.price = ((100 - percernt)/100.0) * product.price;
        }
        public void RestorePrice(Product product) {
            product.price = product.originalPrice;
        }

        //ver mivxvdi uketesad rogor davwero Deletes gamodzaxebis shemtxvevashi(kategoriis washlidan CategoryReposhi)
        //foreach kategoriaze gadarbenisas miwevda washla produqtis kategoriebidan produqtis( product.category.products.Remove(product);) da
        //konfliqti iqmneboda exceptions agdebda
        //(mokled rom vtqva kategoriis washlis dros produqtebis washlas ver vaxerxebdi am klasis Delete metodis daxmarebit radgan
        //roca 1 produqts vshli mashinc am Deletes viyeneb da kategorias vwvdebi da iqedanac vshli produqts)
        public void RemoveFromList(int id) {
            products.Remove(products.FirstOrDefault(x => x.id == id));
        }
    }
}
