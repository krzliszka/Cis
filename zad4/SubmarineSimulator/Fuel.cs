using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class Fuel : IStorable
    {
        public double Amount {get;set;}
        public void HowMuchLeft()
        {
            Console.WriteLine("Fuel: " + Amount + "l.");
        }
    }
}
