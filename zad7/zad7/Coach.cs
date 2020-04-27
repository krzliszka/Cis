using System;

//invoker

namespace zad7
{
    public class Coach
    {
        private ICommand mode;
        public void SetMode(ICommand command)
        {
            mode = command;
        }
        public void ExecuteCommand()
        {
            mode.Execute();
        }
    }
}
