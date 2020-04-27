using System;

//adapter for class Lenovo and interface IMacbook.
//abstract instance of class Macbook is creating first, then there are methods from class Lenovo in which we call methods from new class Macbook

namespace zad7
{
    public class LaptopAdapter : Lenovo
    {
        IMacbook macbook = new Macbook();
        public void ScreenSize(double inch)
        {
            macbook.MacbookScreenSize(inch);
        }
        public void OperatingSystem(string system)
        {
            macbook.MacbookOperatingSystem(system);
        }
        public void Price(double price)
        {
            macbook.MacbookPrice(price);
        }
        public void Processor(string processor)
        {
            macbook.MacbookProcessor(processor);
        }
    }
}
