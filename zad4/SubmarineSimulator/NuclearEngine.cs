using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class NuclearEngine : Engine
    {
        private Waste nuclearWaste;
        public override void CheckSupplies()
        { }
        public NuclearEngine()
        { }
        public override void OneDayOfTravel()
        { }
        public override double Refill(double amount)
        {
            return amount;
        }
    }
}
