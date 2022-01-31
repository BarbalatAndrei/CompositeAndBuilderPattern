using CompositeAndBuilderPattern.CompositePattern;
using System;

namespace CompositeAndBuilderPattern.CarElements
{
    public class WheelDrive : ICar
    {
        public string model { get; set; }
        public bool backFront { get; set; }
        public double price { get; set; }

        public WheelDrive setWheelDrive(string model, bool backFront, double price)
        {
            this.model = model;
            this.backFront = backFront;
            this.price = price;

            return this;
        }
        
        public double getElementPrice()
        {
            return this.price;
        }

        public void showElementDetail()
        {
            Console.WriteLine(">> WheelDrive | Model: {0} | Back/Front: {1} | Price: {2}", this.model, this.backFront, this.price);
        }
        
    }
}