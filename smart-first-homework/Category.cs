using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Product> products { get; set; }

        public Category(string name, List<Product> products)
        {
            this.name = name;
            this.products = products;
        }

        public Category(string name)
        {
            this.name = name;
            products = new List<Product>();
        }
    }
}
