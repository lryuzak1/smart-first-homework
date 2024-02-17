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
        public List<Product> products { get; set; } = new List<Product>();
    }
}
