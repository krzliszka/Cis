using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
     abstract class Caretaker : ICleaning, IFeeding
    {
        public abstract int CleanAnimals();
        public bool IsClean { get; set; }

        public abstract int FeedAnimals();
        public bool IsNotHungry { get; set; }

    }
}
