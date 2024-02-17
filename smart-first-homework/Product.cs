using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
   public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double originalPrice { get; set; } 
        public Category category { get; set; }

        public Product(string name, int quantity, double price, Category category)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.category = category;
            originalPrice = price;
        }

        public Product(string name, double price, Category category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            quantity = 1;
            originalPrice = price;
        }
    }
}
