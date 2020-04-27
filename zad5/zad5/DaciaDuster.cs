using System;
namespace zad5
{
    public class DaciaDuster : ISUV
    {
        public string SUV()
        {
            return "Dacia Dusteeer";
        }
        private double price;
        public DaciaDuster(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
