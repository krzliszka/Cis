using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public abstract class Engine
    {
        public virtual void CheckSupplies()
        { }
        public Engine()
        { }
        public abstract void OneDayOfTravel();

        public abstract double Refill(double amount);
        
    }
}
