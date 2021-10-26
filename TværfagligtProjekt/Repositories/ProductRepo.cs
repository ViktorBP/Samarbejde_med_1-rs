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

        public List<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddProduct(Product product)
        {
            products.Add(product);

            // add streamwrite
        }

        public void SaveProducts(List<Product> products)
        {
            StreamWriter sw = new StreamWriter(ProductPath, append: true);

            foreach (var p in products)
            {
                sw.WriteLine(p.ToString());
            }
            sw.Close();
        }

        public void RemoveAllProducts(List<Product> products)
        {
            products.Clear();
        }



        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
