using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
   
    internal class Deck 
    {
        public Random random = new Random();
        List<Card> deck=new List<Card> { };
        public Deck()
        {
            for (int r = 2; r <= 14; r++)
            {
                for (int s = 0; s <= 3; s++)
                {
                    deck.Add(new Card(r, s));
                }
            }
        }
        public void Shuffle()
        { 
            for (int i = 0; i < deck.Count; i++)
            {
                int rnd = random.Next(deck.Count);
                (deck[i],deck[rnd]) = (deck[rnd],deck[i]);
            }
        }
        public void Show()
        {
            foreach (var card in deck)
            {
                Console.WriteLine(card.rank+" of "+ card.suit);
            }
        }
        public void PickRandomCard()
        {
            int rnd=random.Next(deck.Count);
            Console.WriteLine("Random card : " + deck[rnd].rank + " of " + deck[rnd].suit);
        }
        public void PickFirstCard()
        {
            Console.WriteLine("First card : " + deck[0].rank + " of " + deck[0].suit);
        }


    }
}
