using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    class Pig : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("\n-------");
            Console.WriteLine("oink-oink");
        }
        public override string ToString()
        {
            return "This is a pig. \nBreed: " + Breed + "\nOwner: " + Owner + "\nAge (in months): " + Age + "\nWeight (in kgs): " + Weight;
        }
        public Pig(string breed, string owner, int age, double weight)
        {
            if (age > 0 && weight > 0)
            {
                Breed = breed;
                Owner = owner;
                Age = age;
                Weight = weight;
            }
        }
    }
}
