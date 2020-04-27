using System;
namespace zad5
{
    public class DaciaSandero : ICoupe
    {
        public string Coupe()
        {
            return "Dacia Sandero";
        }
        private double price;
        public DaciaSandero(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
    }
}
