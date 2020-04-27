using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach coach = new Coach();
            JuniorAthlete juniorA = new JuniorAthlete("Jas Fasola",100);
            JuniorAthlete juniorB = new JuniorAthlete("Franek Dolas",90);
            SeniorAthlete seniorA = new SeniorAthlete("Wojciech Suchodolski",0);

            Running running = new Running(juniorA);
            Cycling cycling = new Cycling(juniorB);
            DrinkingBeer drinkingA = new DrinkingBeer(seniorA);
            DrinkingBeer drinkingB = new DrinkingBeer(seniorA);

            coach.SetMode(running);
            coach.ExecuteCommand();
            coach.SetMode(cycling);
            coach.ExecuteCommand();
            coach.SetMode(drinkingA);
            coach.ExecuteCommand();
            coach.SetMode(drinkingB);
            coach.ExecuteCommand();

            Console.WriteLine();
            Console.WriteLine("Adapter:");
            Console.WriteLine("Lenovo parameters: ");

            /*
             * Firstly we call older laptop Lenovo, then class Adapter which has old methods from class Lenovo.
             * In both cases it works the same.
             */

            Lenovo lenovo = new Lenovo();
            lenovo.ScreenSize(15.1);
            lenovo.OperatingSystem("Windows 10");
            lenovo.Price(3999);
            lenovo.Processor("Intel Core i5");

            Console.WriteLine("\nMacbook parameters: ");

            LaptopAdapter laptopAdapter = new LaptopAdapter();
            laptopAdapter.ScreenSize(13.3);
            laptopAdapter.OperatingSystem("Mac OS");
            laptopAdapter.Price(7299);
            laptopAdapter.Processor("Intel Core i7");
        }
    }
}
