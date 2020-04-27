using System;
using System.Collections.Generic;

namespace zad5
{
    class Program
    {
        public void ClientMethod(ICarFactory factory)
        {
            var product1 = factory.DesignSUV();
            var product2 = factory.DesignSedan();


            Console.WriteLine(product1.SUV());
            Console.WriteLine(product2.Sedan());
            //Console.WriteLine(product2.Function(product1));
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("In Cracow Client can buy following cars (luxurious): ");
            Console.WriteLine(new CracowFactory());

            Console.WriteLine();

            Console.WriteLine("In Bialystok Client can buy following cars (common): ");
            new BialystokFactory();

            Console.WriteLine();

            Console.WriteLine("In Warsaw Client can buy following eco cars: ");
            new WarsawFactory();
            */

            /*
            List<ICarFactory> carFactories = new List<ICarFactory>();
            carFactories.Add(new CracowFactory());
            carFactories.Add(new BialystokFactory());
            carFactories.Add(new WarsawFactory());
            
            foreach(ICarFactory factory in carFactories)
            {
                ISUV s = factory.DesignSUV();
                Console.WriteLine(s.SUV() + " PLN" + s.Price);
                Console.WriteLine("------------------------");

                ISedan d = factory.DesignSedan();
                Console.WriteLine(d.Sedan() + " PLN" + d.Price);
                Console.WriteLine("------------------------");

                ICoupe c = factory.DesignCoupe();
                Console.WriteLine(c.Coupe() + " PLN" + c.Price);
                Console.WriteLine("------------------------");
            }*/

            
            Console.WriteLine("In Cracow factory client can order: ");
            ICarFactory factoryA = new CracowFactory();
            ISUV SUVA = factoryA.DesignSUV();
            Console.WriteLine(SUVA.SUV() + " PLN" + SUVA.Price);
            ISedan sedanA = factoryA.DesignSedan();
            Console.WriteLine(sedanA.Sedan() + " PLN" + sedanA.Price);
            ICoupe coupeA = factoryA.DesignCoupe();
            Console.WriteLine(coupeA.Coupe() + " PLN" + coupeA.Price);
            Console.WriteLine();

            Console.WriteLine("In Warsaw factory client can order: ");
            ICarFactory factoryB = new WarsawFactory();
            ISUV SUVB = factoryB.DesignSUV();
            Console.WriteLine(SUVB.SUV() + " PLN" + SUVB.Price);
            ISedan sedanB = factoryB.DesignSedan();
            Console.WriteLine(sedanB.Sedan() + " PLN" + sedanB.Price);
            ICoupe coupeB = factoryB.DesignCoupe();
            Console.WriteLine(coupeB.Coupe() + " PLN" + coupeB.Price);
            Console.WriteLine();

            Console.WriteLine("In Bialystok factory client can order: ");
            ICarFactory factoryC = new BialystokFactory();
            ISUV SUVC = factoryC.DesignSUV();
            Console.WriteLine(SUVC.SUV() + " PLN" + SUVC.Price);
            ISedan sedanC = factoryC.DesignSedan();
            Console.WriteLine(sedanC.Sedan() + " PLN" + sedanC.Price);
            ICoupe coupeC = factoryC.DesignCoupe();
            Console.WriteLine(coupeC.Coupe() + " PLN" + coupeC.Price);

        }
    }
}
