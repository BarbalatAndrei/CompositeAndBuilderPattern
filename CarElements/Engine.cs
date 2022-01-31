using System;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern.CarElements
{
    public class Engine : ICar
    {
        public string model { get; set; }
        public string capacity { get; set; }
        public double price { get; set; }
        
        public Engine setEngine(string model, string capacity, double price)
        {
            this.model = model;
            this.capacity = capacity;
            this.price = price;

            return this;
        }
        
        public double getElementPrice()
        {
            return this.price;
        }

        public void showElementDetail()
        {
            Console.WriteLine(">> Engine | Model: {0} | Capacity: {1} | Price: {2}", this.model, this.capacity, this.price);
        }
    }
}