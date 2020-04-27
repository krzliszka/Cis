using System;

//class inheriting from the abstract class StrategyOfOrder
//it implements specific algorithms.

namespace zad8
{
    public class ChickenBreast : StrategyOfOrder
    {
        public override void Restaurant()
        {
            Console.WriteLine("Client ordered " + GetType().Name + "\n");
        }
    }
}
