using System;

// class Order stores an object of interface StrategyOfOrder, overwrites it and changes, when client wants to operate on another algorithm

namespace zad8
{
    public class Order
    {
        private StrategyOfOrder strategy;
        public Order(StrategyOfOrder strategy)
        {
            this.strategy = strategy;
        }
        public void Restaurant()
        {
            strategy.Restaurant();
        }
    }
}
