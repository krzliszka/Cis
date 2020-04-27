using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class Crewmember : Human
    {
        public Crewmember(double s) : base(s)
        {
            MedianSalary = s;
        }
        public override int Breathe()
        {
            return 200;
        }
        public override double Eat()
        {
            return 7;
        }
    }
}
