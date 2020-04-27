using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class FoodSupply : IStorable
    {
        public double Amount { get; set; }
        public void HowMuchLeft()
        {
            Console.WriteLine("Food supply: " + Amount + "kg.");
        }
    }
}
