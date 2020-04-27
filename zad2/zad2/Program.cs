using System;
using System.Collections.Generic;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dog dog = new Dog("Golden Retriever", "Jack", 13, 15);
             dog.MakeSound();
             Console.WriteLine(dog);

             Cat cat = new Cat("Burmilla", "Chris", 3, 2.3);
             cat.MakeSound();
             Console.WriteLine(cat);

             Pig pig = new Pig("Pork chop", "Butcher", 18, 300.5);
             pig.MakeSound();
             Console.WriteLine(pig);

             Console.ReadKey();
             */

            List<Animal> myAnimals = new List<Animal>();
            myAnimals.Add(new Dog("Golden Retriever", "Jack", 13, 15));
            myAnimals.Add(new Cat("Burmilla", "Chris", 3, 2.3));
            myAnimals.Add(new Pig("Pork chop", "Butcher", 18, 300.5));

            foreach(Animal a in myAnimals)
            {
                a.MakeSound();
                Console.WriteLine(a);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
