using System;
using System.Collections.Generic;
using System.Linq;

namespace zad1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Control posts = new Control("Deleted Posts", "Topic: blablbalbla", -33);  //wywolanie konstruktora parametrycznego
            UserProfile userProfile1 = new UserProfile("2020.02.12", 150, "Banned user", posts);
            Info myInfo = new Info("myInfo", userProfile1);
            myInfo.UserProfile.PostsChange();
            myInfo.UserProfile.ShowUserInfo();
            Console.ReadKey(); 

            List<Info> usersList = new List<Info>();         //lista
            usersList.Add(new Info("User 1 ", new UserProfile("2020.02.12", 150, "Banned user", new Control("Deleted posts ", "Topic: blablbalbla", -33))));
            usersList.Add(new Info("User 2 ", new UserProfile("2019.01.23", 999, "User", new Control("New posts ", "Topic: Hello", 12))));
            usersList.Add(new Info("User 3 ", new UserProfile("2017.12.24", 3230, "Founder", new Control("New posts ", "Topic: Physics exam", 3))));


             foreach(Info element in usersList) //petla foreach
             {
                element.UserProfile.PostsChange();
                element.UserProfile.ShowUserInfo();
             } 
            /*usersList[0].UserProfile.postsChange();
            usersList[0].UserProfile.showUserInfo();
            usersList[1].UserProfile.postsChange();
            usersList[1].UserProfile.showUserInfo();
            usersList[2].UserProfile.postsChange();
            usersList[2].UserProfile.showUserInfo();
            Console.ReadKey();
            */
        }
    }
}
