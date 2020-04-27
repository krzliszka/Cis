using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class ScientificProbe : ITool
    {
        public void Conserve()
        {
            Console.WriteLine("Conserving - PAPRYKARZ SZCZECINSKI");
        }
        public void GatherData()
        {
            Console.WriteLine("Gathering - Gdzie zgubiles swojego paprykarza?");
        }
    }
}
