using System;
using System.Collections.Generic;

//observed class

namespace zad8
{
    public class Auctioneer : ISubject
    {
        private List<IObserver> observerList;

        public Auctioneer()
        {
            observerList = new List<IObserver>();       
        }
        public void DisplayNewPrice()
        {
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach (IObserver o in observerList)
            {
                o.Update();
            }
        }
        public void AddBidder(IObserver o)
        {
            observerList.Add(o);
        }
        public void StartNew()
        {
            Console.WriteLine("Offers: ");
        }
    }
}
