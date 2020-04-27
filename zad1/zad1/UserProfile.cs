using System;
using System.Collections.Generic;
using System.Text;

//w klasie UserProfile jest wlasciwosc z klasy Control

namespace zad1
{
    class UserProfile
    {
        public string RegisterDate { get; set; } //automatyczny getter i setter
        public double Posts { get; set; }
        public string Function { get; set; }

        public Control Control { get; } //getter, bez settera

        public UserProfile(string RegisterDate, int Posts, string Function, Control Control ) //parametrized constructor
        {
            this.RegisterDate = RegisterDate;
            this.Posts = Posts;
            this.Function = Function;
            this.Control = Control;
        }

        private double CalculatePosts(Control control) //metoda prywatna
        {
            double posts = 0;
            posts = control.NumberOfPosts;
            return posts;
            
        }

        public double PostsChange() //metoda publiczna, ktora odwoluje sie do metody prywatnej
        {   
            double posts = CalculatePosts(Control);
            if (posts > 0)
            {
                Posts = Posts + posts;
            } else
            {
                Posts = Posts + posts;
            }
            return Posts;
        }

        public void ShowUserInfo()
        {
            Console.WriteLine("Register Date: " + RegisterDate);
            Console.WriteLine("Posts: " + Posts);
            Console.WriteLine("Function: " + Function);
            Console.WriteLine("-------------------");
        }

    }
}
