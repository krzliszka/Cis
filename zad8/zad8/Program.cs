using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioneer = new Auctioneer();

            Bidder bid1 = new Bidder("Jan Kowalski");   //creating new subscribers
            auctioneer.AddBidder(bid1);

            Bidder bid2 = new Bidder("Filip Rura");
            auctioneer.AddBidder(bid2);

            Bidder bid3 = new Bidder("Karol Nowak");
            auctioneer.AddBidder(bid3);

            Bidder bid4 = new Bidder("Piotr Pawłowski");
            auctioneer.AddBidder(bid4);

            auctioneer.StartNew();      
            bid1.NewPrice(100);     //prices increases
            bid2.NewPrice(200);
            bid3.NewPrice(350);
            bid4.NewPrice(500);
            auctioneer.DisplayNewPrice();
            Console.WriteLine();
            auctioneer.StartNew();
            bid1.NewPrice(600);
            bid2.NewPrice(650);
            bid3.NewPrice(750);
            bid4.NewPrice(700);
            auctioneer.DisplayNewPrice();
            Console.WriteLine();
            auctioneer.StartNew();
            bid1.NewPrice(1000);
            bid2.NewPrice(800);
            bid3.NewPrice(850);
            bid4.NewPrice(1050);
            auctioneer.DisplayNewPrice();
            Console.WriteLine();

            Console.WriteLine("Strategy: ");
            Order order;
            Console.WriteLine("Client wants to eat some chicken.");
            order = new Order(new ChickenBreast());
            order.Restaurant();

            Console.WriteLine("Client wants to eat some potatoes or chips.");
            order = new Order(new Potato());
            order.Restaurant();
        }
    }
}
