using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using ThirdYearWebShop.Data;

namespace Repositories
{
    public class ProductRepoMVC : IProductRepo
    {
        public List<Product> Products { get; set; } = new List<Product>();
        private ProductDbContext db { get; }

        public ProductRepoMVC(ProductDbContext db)
        {
            this.db = db;
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int Id)
        {
            db.Products.Remove(db.Products.Find(Id));
            db.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            foreach (var item in db.Products)
            {
                products.Add(item);
            }
            return products;
        }

        public Product GetProduct(int Id)
        {
            var product = db.Products
                .Find(Id);
            return product;
        }

        public Product UpdateProduct(int Id)
        {
            db.Products.Update(db.Products.Find(Id));
            db.SaveChanges();
            return db.Products.Find(Id);
        }
    }
}
