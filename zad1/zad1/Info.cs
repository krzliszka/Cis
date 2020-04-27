using System;
using System.Collections.Generic;
using System.Text;

//klasa Info zawiera w sobie wlasciwosc klasy UserProfile

namespace zad1
{
    class Info
    {
        public string Name { get; set;}

        public UserProfile UserProfile { get; set;}

        public Info(string Name, UserProfile UserProfile) ///obiekt klasy UserProfile jako wlasciowsc zawarta w klasie Info
        {
            this.Name = Name;
            this.UserProfile = UserProfile;
        }
    }
}
