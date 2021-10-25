using System;

namespace ModelLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Product: {Name}\nDescription: {Description}\nPrice: {Price}\nId: {Id}\n\n";
        }
    }
}
