using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class OxygenSupply : IStorable
    {
        public double Amount { get; set; }
        public double MaxCapacity { get; set; }
        public  void HowMuchLeft()
        {
            Console.WriteLine("Oxygen supply left: " + Amount);
        }
        public OxygenSupply(double capacity)
        {
            MaxCapacity = capacity;
        }

    }
}
