using System;
namespace zad5
{
    public class DaciaLogan : ISedan
    {
        public string Sedan()
        {
            return "Dacia Logan";
        }
        private double price;
        public DaciaLogan(double price)
        {
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
        /*  public string Function(ISUV c)
          {
              var result = c.SUV();

              return $"Wynik kolaboracji 2 z ({result})";
          }*/
    }

}
