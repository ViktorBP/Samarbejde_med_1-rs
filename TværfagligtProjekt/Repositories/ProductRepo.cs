using System;
using System.Collections.Generic;
using ModelLibrary;
using System.IO;

namespace Repositories
{
    public class ProductRepo
    {
        static string ProductPath = "ProductList.txt";

        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
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
    }
}
