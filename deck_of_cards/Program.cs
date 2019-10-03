using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Card mycard = new Card("my card", "my suit",7);
            mycard.initDeck();
            mycard.Deal();
            
        }

        public class Card
        {
            string StringVal;
            string Suit;
            int Val;
            public List<Card> cards;

            public Card(string StringVal, string Suit, int Val)
            {
                this.StringVal = StringVal;
                this.Suit = Suit;
                this.Val = Val;
                initDeck();
            }
            public void initDeck()
            {
                string[] StringValOptions = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
                string[] SuitOptions = { "Hearts", "Clubs", "Diamonds", "Spades" };
                int[] ValOptions = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                for (int i = 0; i < ValOptions.Length; i++)
                {
                    for (int suit = 0; suit < SuitOptions.Length; suit++)
                    {
                        Card madeNewCard = new Card(StringValOptions[i], SuitOptions[suit], ValOptions[i]);
                        cards.Add(madeNewCard);
                        System.Console.WriteLine(cards);
                    }
                }
            }
            public Card Deal()
            {
                System.Console.WriteLine("///////////// Init Deal Method");
                Card dealtCard = cards[0];
                cards.RemoveAt(0);
                return dealtCard;
            }
            public List<Card> Reset()
            {
                System.Console.WriteLine("/////// init Reset()");
                cards.Clear();
                initDeck();
                return cards;
            }
            public List<Card> Shuffle(List<Card> nonShuffled)
            {
                System.Console.WriteLine("////////// init Shuffle() method");
                List<Card> shuffledCards = new List<Card>();
                for(int i = 0; i < nonShuffled.Count; i++)
                {
                    Random rand = new Random();
                    int randomizedCard = rand.Next(0, nonShuffled.Count);
                    System.Console.WriteLine(nonShuffled[randomizedCard]);
                    shuffledCards.Add(nonShuffled[randomizedCard]);
                    nonShuffled.RemoveAt(randomizedCard);
                }
                cards = shuffledCards;
                return cards;
            }
        }
        public class Player
        {
            string Name;
            List<Card> Hand;
            public Card Draw(Card cards)
            {
                System.Console.WriteLine("////////// init Draw() method on Player");
                // 1. grab card at index 0 using Deal()
                Card playerDrawnCard = cards.Deal();
                // 2. Add card to Hand.
                Hand.Add(playerDrawnCard);
                return playerDrawnCard;
            }
        }
    }
}
                                