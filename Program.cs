using System;

namespace Deck
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Card newcard = new Card("Ace","diamond",1);
        //    Console.WriteLine(newcard); 

        Deck deck1 = new Deck();
        deck1.Create();
        //deck1.Deal();
        // deck1.Deal();
        // deck1.Deal();
        //deck1.Reset();
        deck1.Shuffle();
        Player newpl=new Player("Odina");
        newpl.Draw(deck1);
        Console.WriteLine(newpl.PlayerHand);
        newpl.Discard(0);
        Console.WriteLine(newpl.PlayerHand);
        }
    }
}
