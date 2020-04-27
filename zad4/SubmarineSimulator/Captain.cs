using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class Captain : Human
    {
        public Captain(double s) : base(s)
        {
            MedianSalary = s;
        }
        public override int Breathe()
        {
            return 300;
        }
        public override double Eat()
        {
            return 10.5;
        }
    }
}
