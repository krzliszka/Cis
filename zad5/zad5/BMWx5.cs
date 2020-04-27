using System;
namespace zad5
{
    public class BMWx5 : ISUV
    {
        public string SUV()
        {
            return "BMW x5";
        }
        private double price;
        public BMWx5(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
