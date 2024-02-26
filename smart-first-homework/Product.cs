using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double OriginalPrice { get; set; } 
        public Category Category { get; set; }

        public Product(string name, int quantity, double price, Category category)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Category = category;
            OriginalPrice = price;
        }

        public Product(string name, double price, Category category)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            Quantity = 1;
            OriginalPrice = price;
        }
    }
}
