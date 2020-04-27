using System;
namespace zad5
{
    public class TeslaX : ISUV
    {
        public string SUV()
        {
            return "Tesla model X";
        }
        private double price;
        public TeslaX(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
