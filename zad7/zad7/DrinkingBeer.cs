using System;

//command

namespace zad7
{
    public class DrinkingBeer : ICommand
    {
        private SeniorAthlete senior;
        public DrinkingBeer(SeniorAthlete senior)
        {
            this.senior = senior;
        }
        public void Execute()
        {
            senior.StartDrinkingBeer();
        }
    }
}
