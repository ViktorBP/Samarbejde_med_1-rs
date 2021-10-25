using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Basket
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int Amount { get; set; }
        public double TotalPrice { get; set; }

        public override string ToString()
        {
            string str = "";

            foreach (Product p in Products)
            {
                str += p.ToString();
            }

            return str;
        }
    }
}
