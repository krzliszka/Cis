using System;
namespace zad5
{
    public class BMWseries4 : ICoupe
    {
        public string Coupe()
        {
            return "BMW series 4";
        }
        private double price;
        public BMWseries4(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
