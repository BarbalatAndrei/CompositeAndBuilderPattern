using System;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern.CarElements
{
    public class TripComputer : ICar
    {
        public string model { get; set; }
        public string type { get; set; }
        public double price { get; set; }

        public TripComputer setTripComputer(string model, string type, double price)
        {
            this.model = model;
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
            Console.WriteLine(">> TripComputer | Model: {0} | Type: {1} | Price: {2}", this.model, this.type, this.price);
        }
    }
}