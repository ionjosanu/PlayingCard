using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
    public enum Suit { Clubs, Hearts, Spades, Diamonds }
    public class Card
    {
        public Rank rank;
        public Suit suit;
        public Card(int rank, int suit)
        {
            this.rank = (Rank)rank;
            this.suit =(Suit)suit;
        }

      
    }
}
