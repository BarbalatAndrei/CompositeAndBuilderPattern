using System;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern.CarElements
{
    public class BackParktronics : ICar
    {
        public string model { get; set; }
        public int number { get; set; }
        public double price { get; set; }
        
        public BackParktronics setBackParktronics(string model, int number, double price)
        {
            this.model = model;
            this.number = number;
            this.price = price;
            
            return this;
        }
        public double getElementPrice()
        {
            return this.price;
        }

        public void showElementDetail()
        {
            Console.WriteLine(">> BackParktronics | Model: {0} | Number: {1} | Price: {2}", this.model, this.number, this.price);
        }
    }
}