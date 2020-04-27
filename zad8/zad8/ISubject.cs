using System;

//interface used to implement methods needed to add bidders and notify them about new price

namespace zad8
{
    public interface ISubject
    {
        void AddBidder(IObserver o);
        void NotifyObservers();
    }
}
