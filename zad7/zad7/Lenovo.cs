using System;

//any class created to show how the Adapter pattern works

namespace zad7
{
    public class Lenovo
    {
        public void ScreenSize(double inch)
        {
            Console.WriteLine("Screen size in inches: " + inch);
        }
        public void OperatingSystem(string system)
        {
            Console.WriteLine("Lenovo operating system: " + system);
        }
        public void Price(double price)
        {
            Console.WriteLine("Lenovo price (PLN): " + price);
        }
        public void Processor(string processor)
        {
            Console.WriteLine("Lenovo processor: " + processor);
        }
    }
}
