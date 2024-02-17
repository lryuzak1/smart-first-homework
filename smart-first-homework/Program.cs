using System;
using System.Xml.Linq;

namespace smart_first_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();
            var categoryRepository = new CategoryRepository();
            var productService = new ProductService(productRepository);
            var categoryService = new CategoryService(categoryRepository);


            var fruitsCategory = new Category { name="fruits" };
            var vegetablesCategory = new Category { name = "vegetables" };
            var drinksCategory = new Category { name = "drinks" };

            

            var apple = new Product("apple", 2.5, fruitsCategory);
            var banana = new Product("banana", 5, fruitsCategory);
           
            var cabbage = new Product("cabbage", 2.3, vegetablesCategory);
            var potato = new Product("potato", 5, vegetablesCategory);
            
            var pepsi = new Product("pepsi", 1, drinksCategory);
            var vodka = new Product("vodka", 15, drinksCategory);

            categoryService.Add(fruitsCategory);
            categoryService.Add(vegetablesCategory);
            categoryService.Add(drinksCategory);

            productService.Add(apple, fruitsCategory);
            productService.Add(banana, fruitsCategory);

            productService.Add(cabbage, vegetablesCategory);
            productService.Add(potato, vegetablesCategory);

            productService.Add(pepsi, drinksCategory);
            productService.Add(vodka, drinksCategory);

            //print all products by category
            foreach (Category category in categoryService.GetAll()) {
                Console.Write("Category: ID: " +category.id+ ", Name: "+ category.name+"\n" + "Products:");
                foreach (Product product in categoryService.GetProducts(category)) {
                    Console.Write("[ID: "+product.id+", "+ "name: " + product.name+", price: "+product.price+"] ");
                }
                Console.Write("\n");
            }

            //remove fruit category (Category ID:1)
            categoryService.Delete(1,productRepository);
            //remove potato  from different vegetables (Product ID:4)
            productService.Delete(4);
            //discount vodka by 20%
            productService.MakeDiscount(21, vodka);

            Console.WriteLine();
            Console.WriteLine("after changes: \n");


            //print all products by category
            foreach (Category category in categoryService.GetAll())
            {
                Console.Write("Category: ID: " + category.id + ", Name: " + category.name + "\n" + "Products:");
                foreach (Product product in categoryService.GetProducts(category))
                {
                    Console.Write("[ID: " + product.id + ", " + "name: " + product.name + ", price: " + product.price + "] ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
