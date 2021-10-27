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
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Velkommen til vores webshop, hvad vil du gøre? \n-------------------------------------\n");
            Console.WriteLine("1. Vis liste af produkter");
            Console.WriteLine("2. Tilføj et produkt");
            Console.WriteLine("3. Ryd Listen");

            switch (Console.ReadLine())
            {

                case "1":
                    List<Product> tempproducts = repo.GetAllProducts();
                    foreach (Product p in tempproducts)
                    {
                        Console.WriteLine(p.ToString()); 
                    }
                        Console.ReadLine();
                    break;

                    case "2":
                    Console.WriteLine("Indtast navn på produkt");
                    string productName = Console.ReadLine();
                    Console.WriteLine("Indtast id på produkt");
                    string productId = Console.ReadLine();
                    Console.WriteLine("Indtast prisen på produkt");
                    string productPrice = Console.ReadLine();
                    Console.WriteLine("Lav en beskrivelse på produkt");
                    string productDescription = Console.ReadLine();
                    Console.WriteLine(productName + " er nu blevet tilføjet");

                    Product product1 = new Product(productName, int.Parse(productId), double.Parse(productPrice), productDescription);

                    products.Add(product1);
                        repo.AddProduct(product1);
                    Console.ReadLine();
                    break;

                    case "3":
                        repo.RemoveAllProducts();
                        Console.WriteLine("Listen er nu blevet ryddet");
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
