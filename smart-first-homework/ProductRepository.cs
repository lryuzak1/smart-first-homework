using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> Products = new List<Product>();
        public void Add(Product item,Category category)
        {
            Products.Add(item);
            category.Products.Add(item);
            item.Id = Products.Count();
        }

        public void Delete(int id)
        {
            Product product = Products.FirstOrDefault(x => x.Id == id);
            
            Products.Remove(product);

            product.Category.Products.Remove(product);    
        }

        public IEnumerable<Product> GetAll()
        {
            return Products;
        }

        public Product GetByID(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id); 
        }

        public void MakeDiscount(int percernt, Product product)
        {
            product.Price = ((100 - percernt)/100.0) * product.Price;
        }
        public void RestorePrice(Product product) {
            product.Price = product.OriginalPrice;
        }

        //ver mivxvdi uketesad rogor davwero Deletes gamodzaxebis shemtxvevashi(kategoriis washlidan CategoryReposhi)
        //foreach kategoriaze gadarbenisas miwevda washla produqtis kategoriebidan produqtis( product.category.Products.Remove(product);) da
        //konfliqti iqmneboda exceptions agdebda
        //(mokled rom vtqva kategoriis washlis dros produqtebis washlas ver vaxerxebdi am klasis Delete metodis daxmarebit radgan
        //roca 1 produqts vshli mashinc am Deletes viyeneb da kategorias vwvdebi da iqedanac vshli produqts)
        public void RemoveFromList(int id) {
            Products.Remove(Products.FirstOrDefault(x => x.Id == id));
        }
    }
}
