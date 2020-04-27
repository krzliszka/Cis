using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("\n-------");
            Console.WriteLine("meow-meow");
        }
        public override string ToString()
        {
            return "This is a cat. \nBreed: " + Breed + "\nOwner: " + Owner + "\nAge (in months): " + Age + "\nWeight (in kgs): " + Weight;
        }
        public Cat(string breed, string owner, int age, double weight)
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
