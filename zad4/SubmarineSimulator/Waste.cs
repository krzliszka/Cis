using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class Waste : IStorable
    {
        private string name;
        public double Amount { get; set; }
        public  void HowMuchLeft() 
        {
            Console.WriteLine("Waste collected on the submarine: " + Amount + "kg.");
        }
        public Waste(string s)
        {
            name = s;
        }
    }
}
