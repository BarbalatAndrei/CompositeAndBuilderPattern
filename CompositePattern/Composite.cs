using CompositeAndBuilderPattern.CompositePattern;
using System;
using System.Collections.Generic;

namespace CompositeAndBuilderPattern.CompositePattern
{
    public class Composite : ICar
    {
        private List<ICar> _elements = new List<ICar>();
        public double price = 0;
        public double getElementPrice()
        {
            foreach (var elem in _elements)
            {
               price += elem.getElementPrice();
            }

            return price;
        }

        public void showElementDetail()
        {
            foreach (var elem in _elements)
            {
                elem.showElementDetail();
            }
        }

        public void addElement(ICar elem)
        {
            _elements.Add(elem);
        }

        public void removeElement(ICar elem)
        {
            _elements.Remove(elem);
        }
    }
}