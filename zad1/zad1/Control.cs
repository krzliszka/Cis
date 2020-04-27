using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    class Control
    {
        private string type;
        public string Type
        {
            get { return type; } //napisany getter i setter
            set
            {
              type = Type;
            }
        }

        public string Topic{ get; set; }

        public double NumberOfPosts { get; set; }

        public Control(string Type, string Title, double NumberOfPosts) //parametrized constructor
        {
            this.Type = Type;                   // this odwoluje sie do biezacego wystapienia klasy i kwalifikuje czlonkow 
            this.Topic = Title;                 // ukrytych przy uzyciu podobnych nazw zamiast parametrow konstruktora
            this.NumberOfPosts = NumberOfPosts;
        }

        public void ShowControlInfo()
        {
            Console.WriteLine("Type: " + Topic);
            Console.WriteLine("Topic: " + Topic);
            Console.WriteLine("Number of posts: " + NumberOfPosts);
        }
    }
}
