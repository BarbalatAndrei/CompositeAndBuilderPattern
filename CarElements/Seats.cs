using System;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern.CarElements
{
    public class Seats : ICar
    {
        public int number { get; set; }
        public string material { get; set; }
        public double price { get; set; }

        public Seats setSeats(int number, string material, double price)
        {
            this.number = number;
            this.material = material;
            this.price = price;

            return this;
        }
        
        public double getElementPrice()
        {
            return this.price;
        }

        public void showElementDetail()
        {
            Console.WriteLine(">> Seats | Number: {0} | Material: {1} | Price: {2}", this.number, this.material, this.price);
        }
    }
}