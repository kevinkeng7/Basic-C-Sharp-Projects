using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_or_BlackJack
{
    public struct Card
    {
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }
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
