using System;
using System.Collections.Generic;

/* observing class
 * there is an extension of method Update and
when the price is higher than 1000, auction ends*/

namespace zad8
{
    public class Bidder : IObserver
    {
        private string name;
        public double bidPrice;

        public Bidder(string name)
        {
            this.name = name;
        }
        public void Update()    //extension of method Update()
        {
            Console.WriteLine(name + " proposes: " + bidPrice);

            if (bidPrice > 1000)
            {
                Console.WriteLine("Item sold! The winner is: " + name);
            }
        }
        public void NewPrice(double price)
        {
            bidPrice = price;
        }
    }
}
