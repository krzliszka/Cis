using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class Scientist : Human
    {
        public override int Breathe()
        {
            return 120;
        }
        public override double Eat()
        {
            return 3.5;
        }
        public Scientist(double s) : base(s)
        {
            MedianSalary = s;
        }
        public void Work()
        { }
        public ScientificProbe myProbe { get; set; }
    }
}
