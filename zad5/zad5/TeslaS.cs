using System;
namespace zad5
{
    public class TeslaS : ISedan
    {
        public string Sedan()
        {
            return "Tesla S";
        }
        private double price;
        public TeslaS(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
