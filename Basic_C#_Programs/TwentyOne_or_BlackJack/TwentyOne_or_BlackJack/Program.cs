using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_or_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            int sum = numberList.Where(x => x > 20).Sum();

            Console.WriteLine(sum);
            
            Console.ReadLine();

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
 

    }
}
//Deck deck = new Deck(); //Lambda expressions
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 }; //Lambda expressions
//int sum = numberList.Where(x => x > 20).Sum(); // creates a new list where the items are > 20 and then sum that list
//Console.WriteLine(sum); //Lambda expressions
//Console.ReadLine(); //Lambda expressions

//int sum = numberList.Max(); //would get the maximum number in the list. lambda function
//int sum = numberList.Mix(); //would get the minimum number in the list. 


//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); // lambda function (result = King King King King
//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}


//int count = deck.Cards.Count(x => x.Face == Face.Ace); //lambda function to count all aces in deck (result = 4)

//Deck deck = new Deck(); //counting number of aces in a deck (replace with lambda function - adv. technique)

//int counter = 0;
//foreach (Card card in deck.Cards)
//{
//    if (card.Face == Face.Ace)
//    {
//        counter++;
//    }
//}
//Console.WriteLine(counter); //counting number of aces in a deck 

//Card card1 = new Card(); //structs
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//Console.WriteLine(card1.Face);

//Card card = new Card();  //enum
//card.Suit = Suit.Clubs;
////int underlyingValue = (int)Suit.Diamonds;
//int underlyingValue = Convert.ToInt32(Suit.Diamonds);
//Console.WriteLine(underlyingValue);

//Player<Card> player = new Player<Card>();
//player.Hand = new List<Card>();

//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game += player; // same thing as saying "game = game + player"
//game -= player; //same thing as saying "game = game - player"

//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
//game.ListPlayers();
//Console.ReadLine();

//List<Game> games = new List<Game>();  //polymorphism
//TwentyOneGame game = new TwentyOneGame();  //polymorphism
//games.Add(game); //polymorphism
//PokerGame
//SolitaireGame //etc

//TwentyOneGame game = new TwentyOneGame(); //inheritance example
//game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
//game.ListPlayers();
//game.Play();
//Console.ReadLine();


//public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
//{
//    timesShuffled = 0;
//    for (int i = 0; i < times; i++)
//    {
//        timesShuffled++;
//        List<Card> TempList = new List<Card>();
//        Random random = new Random();

//        while (deck.Cards.Count > 0)
//        {
//            int randomIndex = random.Next(0, deck.Cards.Count);
//            TempList.Add(deck.Cards[randomIndex]);
//            deck.Cards.RemoveAt(randomIndex);
//        }
//        deck.Cards = TempList;
//    }

//    return deck;
//}
//public static Deck Shuffle(Deck deck, int times)
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;
//}


//deck.Cards = new List<Card>();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
//Console.ReadLine();

//Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
//Console.ReadLine();
