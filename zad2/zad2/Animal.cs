using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    abstract class Animal
    {
        public string Breed { get; set; }
        public string Owner { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Unspecified animal");
        }
        
    }
}
