using System;

//receiver

namespace zad7
{
    public class JuniorAthlete
    {
        private string id;
        private double stamina;
        public JuniorAthlete(string id, double stamina)
        {
            this.id = id;
            this.stamina = stamina;
        }
        public void StartRunning()
        {
            stamina -= 50.5;
            Console.WriteLine("Junior athlete " + id + " is running now. Stamina left (out of 100): " + stamina);
        }
        public void StartCycling()
        {
            stamina -= 70;
            Console.WriteLine("Junior athlete " + id + " is cycling now. Stamina left (out of 100): " + stamina);
        }
    }
}
