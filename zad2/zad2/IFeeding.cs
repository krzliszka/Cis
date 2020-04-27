using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    interface IFeeding
    {
        int FeedAnimals();
        bool IsNotHungry { get; set; }
    }
}
