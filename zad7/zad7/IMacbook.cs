using System;

//interface for class Macbook - incompatible with class Lenovo

namespace zad7
{
    public interface IMacbook
    {
        public void MacbookScreenSize(double inch);
        public void MacbookOperatingSystem(string system);
        public void MacbookPrice(double price);
        public void MacbookProcessor(string processor);
    }
}
