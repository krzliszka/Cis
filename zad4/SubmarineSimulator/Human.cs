using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    abstract class Human
    {
        public static double MedianSalary;
        private Random random;
        public double Salary { get; set; }
        public abstract int Breathe();

        public abstract double Eat();
        
        public Human(double s)
        {
            MedianSalary = s;
            random = new Random((int)DateTime.Now.Ticks);
        }
    }
}
