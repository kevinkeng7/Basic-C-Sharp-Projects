using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two, //0
        Three, //1
        Four, //2
        Five,
        Six, 
        Seven,
        Eight,
        Nine,
        Ten, 
        Jack,
        Queen,
        King,
        Ace


    }
}


//public Card()
//{
//    Suit = "Spades";
//    Face = "Two";
//}
