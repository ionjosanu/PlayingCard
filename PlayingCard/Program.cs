using System;

namespace PlayingCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck=new Deck();
            Console.WriteLine("    Initial deck : ");
            deck.Show();
            Console.WriteLine("--------------------------Suffled Deck------------------------------------");
            deck.Shuffle();
            deck.Show();
            Console.WriteLine("--------------------------------------------------------------");
            deck.Shuffle();
            deck.PickRandomCard();
            deck.PickFirstCard();
        }
    }
}
