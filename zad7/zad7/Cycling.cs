using System;

//command

namespace zad7
{
    public class Cycling : ICommand
    {
        private JuniorAthlete junior;
        public Cycling(JuniorAthlete junior)
        {
            this.junior = junior;
        }
        public void Execute()
        {
            junior.StartCycling();
        }
    }
}
