using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    class NavigationPanel : ITool
    {
        public int currentNumber = new int();
        public List<Destination> ports = new List<Destination>();
        public List<int> travelDays = new List<int>();
        public int TotalNumber { get; set; }
        public void AddPort(string name, int days)
        {
            Destination dest = new Destination(name);
            ports.Add(dest);
            travelDays.Add(days);
        }
        public void Arrived()
        {
            currentNumber++;
        }
        public void Conserve()
        { }
        public int DaysToNextDestination()
        {
            int myDest = travelDays[currentNumber];
            return myDest;
        }
        public string NextDestination()
        {
            return ports[currentNumber].Name;
        }
        public void ShowTotal()
        {
            Console.WriteLine("Total: " + TotalNumber);
        }
        public void ShowAllPorts()
        {
            foreach (Destination d in ports)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine(ports.Count);
            }
        }
        public NavigationPanel()
        { }
    }
}
