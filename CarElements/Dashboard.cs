using System;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern.CarElements
{
    public class Dashboard : ICar
    {
        public string type { get; set; }
        public double price { get; set; }

        public Dashboard setDashboard(string type, double price)
        {
            this.type = type;
            this.price = price;

            return this;
        }
        
        public double getElementPrice()
        {
            return this.price;
        }

        public void showElementDetail()
        {
            Console.WriteLine(">> Dashboard | Type: {0} | Price: {1}", this.type, this.price);
        }
    }
}