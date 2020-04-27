using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class DieselEngine : Engine
    {
        public override void OneDayOfTravel()
        {
        }
        public override double Refill(double amount)
        {
            return amount;
        }
    }
}
