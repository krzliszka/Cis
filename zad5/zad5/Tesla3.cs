using System;
namespace zad5
{
    public class Tesla3 : ICoupe
    {
        public string Coupe()
        {
            return "Tesla model 3";
        }
        private double price;
        public Tesla3(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
