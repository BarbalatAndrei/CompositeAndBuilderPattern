using System;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern.CarElements
{
    public class Roof : ICar
    {
        public string type { get; set; }
        public string length { get; set; }
        public double price { get; set; }

        public Roof setRoof(string type, string length, double price)
        {
            this.type = type;
            this.length = length;
            this.price = price;

            return this;
        }
        
        public double getElementPrice()
        {
            return this.price;
        }

        public void showElementDetail()
        {
            Console.WriteLine(">> Roof | Type: {0} | length: {1} | Price: {2}", this.type, this.length, this.price);
        }
    }
}