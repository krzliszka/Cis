using System;

//receiver

namespace zad7
{
    public class SeniorAthlete
    {
        private string id;
        private double beer;
        public SeniorAthlete(string id,double beer)
        {
            this.id = id;
            this.beer = beer;
        }
        public void StartDrinkingBeer()
        {
            beer++;
            Console.WriteLine("Senior athlete " + id + " is drinking beer now. He has already drunk " + beer + " beer(s).");
        }
    }
}
