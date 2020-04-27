using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    interface IStorable
    {
        public double Amount { get; set; }
        public virtual void HowMuchLeft()
        { }
    }
}
