using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleGame
        //Pokerish
        //5 Random Number Generators Individual
        //rng(1, 11)
        //if you complete task(5 of a kind) = Yahtzee(task) Add to score(value)
        /* enum for Entities(task) and Values(score)
         * High Number = 1
         * One Pair = 2
         * Two Pair = 3
         * 3 of a kind = 4 
         * Small Straight = 5 
         * Full House = 6
         * 4 of a kind = 7
         * Large Straight = 8 
         * Five of a kind = 9
          */
{
    public enum PokerAndValues
    {
        HighNumber = 1,
        OnePair = 2,
        TwoPair = 3,
        ThreeOfAKind = 4,
        SmallStraight = 5,
        FullHouse = 6,
        FourOfAKind = 7,
        LargeStraight = 8,
        FiveOfAKind = 9
    }
    //poco
    //plain old csharp objects
    public class PokerishGame
    {
        public PokerishGame() { }

        public PokerishGame(string playerOne, int score, PokerAndValues values)
        {
            PlayerOne = playerOne;
            Score = score;
            Values = values;
        }

        public string PlayerOne { get; set; }

        public int Score { get; set; }

        public PokerAndValues Values { get; set; }

        public Random RandomNumber { get; set; }

        public bool HoldState { get; set; }

        /*public static readonly Dictionary<string, int> keyValues = new Dictionary<string, int>
        {
            { "One Pair", (int)PokerAndValues.OnePair },
            { "Two Pair", (int)PokerAndValues.TwoPair },
            { "Three of a Kind", (int)PokerAndValues.ThreeOfAKind },
            { "Small Straight", (int)PokerAndValues.SmallStraight },
            { "Full House", (int)PokerAndValues.FullHouse },
            { "Four of a Kind", (int)PokerAndValues.FourOfAKind },
            { "Large Straight", (int)PokerAndValues.LargeStraight },
            { "Five of a Kind", (int)PokerAndValues.FiveOfAKind }
        };*/
    }
    /*Assign each rng a number(string),
    *Directory to store saved values(numbers),
    *A way to turn off certain saved rng (so it won't roll again)
    *--Use if else loop with bools to give options of which dice to keep
    *---if(userInput == "1") then isRunning = false; return;
    *Directory to store each round saved last for each player
    *-to reference later for scoring
    *give option on what entities are available for scoring
    *limit of 3 rolls per turn
    *
    *controls roll count per turn
    *roll count
    *controls whether die is held
    *hold count
    *
    */


}
