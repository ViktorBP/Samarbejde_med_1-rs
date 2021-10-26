using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IProductRepo
    {
        public List<Product> Products { get; set; }

        public void AddProduct(Product product);
        public Product GetProduct(int Id);
        public List<Product> GetAllProducts();
        public Product UpdateProduct(Product product);
        public void DeleteProduct(int Id);
    }
}
