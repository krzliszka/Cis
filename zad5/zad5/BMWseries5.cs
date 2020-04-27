using System;
namespace zad5
{
    public class BMWseries5 : ISedan
    {
        public string Sedan()
        {
            return "BMW series 5";
        }
        private double price;
        public BMWseries5(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
