using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_567
{
    class Book : IItem
    {
        public string Title { get; private set; }
        public double Price { get; private set; }
        public Book(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            return "VHS: " + this.Title +
           Environment.NewLine + " -> Price: " + this.Price;
        }
        public double Accept(IVisitor visitor) { return visitor.Visit(this); }
    }
}
