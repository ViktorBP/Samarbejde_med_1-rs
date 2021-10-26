using ModelLibrary;
using System;
using System.Collections.Generic;
using Repositories;

namespace FørsteÅrs
{
    public class Program
    {
        static bool KeepRunning = true;
        static void Main(string[] args)
        {
            ProductRepo repo = new ProductRepo("txt");

            List<Product> products = new List<Product>
            {
                new Product("Bamse", 5038, 100.0, "Flot og nuttet"),
                new Product("Bil", 7294, 150.0, "Hurtig og sjov")
            };
            while (KeepRunning)
            {
                Console.Clear();
Console.WriteLine("Velkommen til vores webshop, hvad vil du gøre?");
            Console.WriteLine("1. Gem produkterne");
            Console.WriteLine("2. Vis liste af produkter");
            Console.WriteLine("3. Tilføj et produkt");

            switch (Console.ReadLine())
            {
                case "1":
                    repo.SaveProducts(products);
                    break;

                case "2":
                    repo.GetAllProducts();
                    foreach (var item in repo.GetAllProducts())
                    {
                        Console.WriteLine(item.ToString()); 
                    }
                        Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("Indtast navn på produkt");
                    string productName = Console.ReadLine();
                    Console.WriteLine("Indtast id på produkt");
                    string productId = Console.ReadLine();
                    Console.WriteLine("Indtast prisen på produkt");
                    string productPrice = Console.ReadLine();
                    Console.WriteLine("Lav en beskrivelse på produkt");
                    string productDescription = Console.ReadLine();

                    Product product1 = new Product(productName, int.Parse(productId), double.Parse(productPrice), productDescription);

                    products.Add(product1);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Ugyldigt input");
                    break;
            }
            }
            

           

            
            //Basket basket = new Basket();
            //basket.Products.Add(new Product() { Name = "bitch", Description = "very bitchy", Id = 52, Price = 13.41 });
            //basket.Products.Add(new Product() { Name = "asda", Description = "hsthxfg", Id = 55, Price = 133.41 });
            //basket.Products.Add(new Product() { Name = "hdfh", Description = "5", Id = 515, Price = 13.1 });
            //basket.Products.Add(new Product() { Name = "zxc", Description = "vitchy", Id = 25, Price = 12.41 });

            //Console.WriteLine(basket.ToString());
        }
    }
}
