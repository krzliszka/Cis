using System;

//class with other methods than in class Lenovo, but they can do the same after using an adapter pattern

namespace zad7
{
    public class Macbook : IMacbook
    {
        public void MacbookScreenSize(double inch)
        {
            Console.WriteLine("Screen size in inches: " + inch);
        }
        public void MacbookOperatingSystem(string system)
        {
            Console.WriteLine("Macbook operating system: " + system);
        }
        public void MacbookPrice(double price)
        {
            Console.WriteLine("Macbook price (PLN): " + price);
        }
        public void MacbookProcessor(string processor)
        {
            Console.WriteLine("Macbook processor: " + processor);
        }
    }
}
