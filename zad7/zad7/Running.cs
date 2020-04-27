using System;

//command

namespace zad7
{
    public class Running : ICommand
    {
        private JuniorAthlete junior;
        public Running (JuniorAthlete junior)
        {
            this.junior = junior;
        }
        public void Execute()
        {
            junior.StartRunning();
        }
    }
}
