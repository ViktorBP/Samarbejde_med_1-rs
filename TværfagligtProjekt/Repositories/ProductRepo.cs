using System;
using System.Collections.Generic;
using ModelLibrary;
using System.IO;

namespace Repositories
{
    public class ProductRepo : IProductRepo
    {
        static string ProductPath = "ProductList.txt";

        private List<Product> products = new List<Product>();
        private readonly string token;

        public List<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ProductRepo(string token)
        {
            this.token = token;
        }

        public void AddProduct(Product product)
        {
            switch (token)
            {
                case "txt":
                    products.Add(product);

                    StreamWriter sw = File.AppendText(ProductPath);

                    sw.WriteLine($"{product.Id};{product.Name};{product.Price};{product.Description}");

                    sw.Close();
                    break;
                default:
                    break;
            }
        }

        public void SaveProducts(List<Product> products)
        {
            switch (token)
            {
                case "txt":

                    break;
                default:
                    break;
            }
            StreamWriter sw = new StreamWriter(ProductPath, append: true);

            foreach (var p in products)
            {
                sw.WriteLine($"{p.Id};{p.Name};{p.Price};{p.Description}");
            }
            sw.Close();
        }

        public void RemoveAllProducts(List<Product> products)
        {
            switch (token)
            {
                case "txt":
                    products.Clear();

                    StreamWriter sw = new StreamWriter(ProductPath);
                    sw.Write("");

                    sw.Close();
                    break;
                default:
                    break;
            }
        }



        public Product GetProduct(int Id)
        {
            switch (token)
            {
                case "txt":
                    StreamReader sr = new StreamReader(ProductPath);
                    Product product = new Product();

                    if (!File.Exists(ProductPath))
                    {
                        return null;
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] args = sr.ReadLine().Split(';');

                        if (Id == int.Parse(args[0]))
                        {
                            product.Id = int.Parse(args[0]);
                            product.Name = args[1];
                            product.Price = double.Parse(args[2]);
                            product.Description = args[3];
                            break;
                        }
                    }

                    sr.Close();
                    return product;

                default:
                    break;
            }

            return null;
        }

        public List<Product> GetAllProducts()
        {
            switch (token)
            {
                case "txt":
                    StreamReader sr = new StreamReader(ProductPath);
                    List<Product> products = new List<Product>();
                    Product product = new Product();

                    if (!File.Exists(ProductPath))
                    {
                        return null;
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] args = sr.ReadLine().Split(';');

                        product.Id = int.Parse(args[0]);
                        product.Name = args[1];
                        product.Price = double.Parse(args[2]);
                        product.Description = args[3];

                        products.Add(product);
                    }

                    sr.Close();
                    return products;

                default:
                    break;
            }

            return null;
        }

        public Product UpdateProduct(int Id)
        {
            switch (token)
            {
                case "txt":
                    StreamReader sr = new StreamReader(ProductPath);
                    Product product = new Product();

                    if (!File.Exists(ProductPath))
                    {
                        return null;
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] args = sr.ReadLine().Split(';');

                        if (Id == int.Parse(args[0]))
                        {
                            product.Id = int.Parse(args[0]);
                            product.Name = args[1];
                            product.Price = double.Parse(args[2]);
                            product.Description = args[3];
                            break;
                        }
                    }
                    sr.Close();

                    bool temp = true;
                    while (temp)
                    {
                        Console.WriteLine("Hvad vil du ændre?");
                        Console.WriteLine("1 - Navn");
                        Console.WriteLine("2 - Pris");
                        Console.WriteLine("3 - Id");
                        Console.WriteLine("4 - Beskrivelse");
                        Console.WriteLine("5 - Done");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                product.Name = Console.ReadLine();
                                break;
                            case "2":
                                product.Price = double.Parse(Console.ReadLine());
                                break;
                            case "3":
                                product.Id = int.Parse(Console.ReadLine());
                                break;
                            case "4":
                                product.Description = Console.ReadLine();
                                break;
                            case "5":
                                temp = false;
                                break;
                            default:
                                Console.WriteLine("Not an option mah dude");
                                break;
                        }
                    }
                    AddProduct(product);
                    return product;

                default:
                    break;
            }
            return null;
        }

        public void DeleteProduct(int Id)
        {
            switch (token)
            {
                case "txt":
                    StreamReader sr = new StreamReader(ProductPath);
                    List<Product> tempProducts = new List<Product>();
                    Product product = new Product();

                    while (!sr.EndOfStream)
                    {
                        string[] args = sr.ReadLine().Split(';');

                        product.Id = int.Parse(args[0]);
                        product.Name = args[1];
                        product.Price = double.Parse(args[2]);
                        product.Description = args[3];

                        if (!(Id == product.Id))
                        {
                            tempProducts.Add(product);
                        }
                    }

                    sr.Close();

                    products = tempProducts;

                    StreamWriter sw = new StreamWriter(ProductPath);

                    foreach (var p in tempProducts)
                    {
                        sw.WriteLine($"{p.Id};{p.Name};{p.Price};{p.Description}");
                    }

                    sw.Close();
                    break;
                default:
                    break;
            }
            
        }
    }
}
