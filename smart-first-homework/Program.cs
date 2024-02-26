using smart_first_homework.Database;
using smart_first_homework.Services;
using smart_first_homework.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace smart_first_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //var productRepository = new ProductRepository();
            //var categoryRepository = new CategoryRepository();
            //var productService = new ProductService(productRepository);
            //var categoryService = new CategoryService(categoryRepository);


            //var fruitsCategory = new Category { Name="fruits" };
            //var vegetablesCategory = new Category { Name = "vegetables" };
            //var drinksCategory = new Category { Name = "drinks" };

            

            //var apple = new Product("apple", 2.5, fruitsCategory);
            //var banana = new Product("banana", 5, fruitsCategory);
           
            //var cabbage = new Product("cabbage", 2.3, vegetablesCategory);
            //var potato = new Product("potato", 5, vegetablesCategory);
            
            //var pepsi = new Product("pepsi", 1, drinksCategory);
            //var vodka = new Product("vodka", 15, drinksCategory);

            //categoryService.Add(fruitsCategory);
            //categoryService.Add(vegetablesCategory);
            //categoryService.Add(drinksCategory);

            //productService.Add(apple, fruitsCategory);
            //productService.Add(banana, fruitsCategory);

            //productService.Add(cabbage, vegetablesCategory);
            //productService.Add(potato, vegetablesCategory);

            //productService.Add(pepsi, drinksCategory);
            //productService.Add(vodka, drinksCategory);

            ////print all products by category
            //foreach (Category category in categoryService.GetAll()) {
            //    Console.Write("Category: ID: " +category.Id+ ", Name: "+ category.Name+"\n" + "Products:");
            //    foreach (Product product in categoryService.GetProducts(category)) {
            //        Console.Write("[ID: "+product.Id+", "+ "name: " + product.Name+", price: "+product.Price+"] ");
            //    }
            //    Console.Write("\n");
            //}

            ////remove fruit category (Category ID:1)
            //categoryService.Delete(1,productRepository);
            ////remove potato  from different vegetables (Product ID:4)
            //productService.Delete(4);
            ////discount vodka by 20%
            //productService.MakeDiscount(21, vodka);

            //Console.WriteLine();
            //Console.WriteLine("after changes: \n");


            ////print all products by category
            //foreach (Category category in categoryService.GetAll())
            //{
            //    Console.Write("Category: ID: " + category.Id + ", Name: " + category.Name + "\n" + "Products:");
            //    foreach (Product product in categoryService.GetProducts(category))
            //    {
            //        Console.Write("[ID: " + product.Id + ", " + "name: " + product.Name + ", price: " + product.Price + "] ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            var database = new MyContext();
            var personService = new PersonService(database);
            var person = new Person() {
                FirstName = "lasha",
                Lastname = "samsonia",
                DateOfBirth = new DateTime(1999, 1, 3),
                Address = new Address() { City = "Tbilisi", Street = "Dadiani", Zipcode = "2500" },
                Emails = new List<Email> { new Email { EmailAddress = "lasha.samsonia@yaho.com", IsPrimary = true } },
                Gender = Gender.Male,
                PhoneNumbers = new List<PhoneNumber> { new PhoneNumber {Number= "555112233",PhoneNumberType=PhoneNumberType.Mobile } }
            };

            //personService.AddPerson(person);
            //var resAddress = personService.GetAddress(15);
            //personService.UpdatePersonAddress(1, new Address { City = "Kutaisi", Street = "Amagleba", Zipcode = "111" });
            //personService.DeletePersonPhoneNumbers(1);
            //personService.GetEmail(1);
            //Console.WriteLine(personService.GetPersonsByStreet("dadiani").Count());
            //Console.WriteLine(personService.GetPersonsByEmail("lasha.samsonia@yaho.com").Count());
           // Console.WriteLine(personService.GetPerson(2).Emails.First().EmailAddress);

        }
    }
}
