using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleGame
{
    public class ProgramUI
    {
        PokerishRepository _repo = new PokerishRepository();
        Random RandomNumber = new Random();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Welcome to Pokerish\n\n" +
                    "1. Play New Game\n" +
                    "2. Play Again\n" +
                    "0. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Play New Game
                        NewGames();
                        break;
                    case "2":
                        //Play Again
                        PlayAgain();
                        break;
                    case "0":
                        //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection 0 or 1.");
                        WriteRead();
                        break;
                }
            }
        }
        private void NewGames()
        {
            Console.Clear();

            PokerishGame pokerish = new PokerishGame();

            Console.WriteLine("Name your player:\n\n" +
                "Player 1:\n");
            pokerish.PlayerOne = Console.ReadLine();

            _repo.AddToDirectory(pokerish);

            Console.Clear();

            Console.WriteLine("Roll the dice!\n" +
                "Try to get your best Pokerish Hand!");
            Console.ReadLine();

            TheActualGame();

        }

        private void TheActualGame()
        {
            Console.Clear();
            List<PokerishGame> pokerishGames = _repo.GetName();
            foreach (PokerishGame name in pokerishGames)
            {

                PlayerOneRolls(name);

                Test();

                WriteRead();
                Console.WriteLine("Congratulations on rolling dice! You really are the best!\n" +
                    "Have a wonderful day!");
            }
            WriteRead();
        }



        int[] dice = new int[5];
        private void Test()
        {
            dice[0] = RandomNumber.Next(1, 11);
            dice[1] = RandomNumber.Next(1, 11);
            dice[2] = RandomNumber.Next(1, 11);
            dice[3] = RandomNumber.Next(1, 11);
            dice[4] = RandomNumber.Next(1, 11);
            Dice();

            Console.WriteLine("Which numbers would you like to Reroll:\n" +
                "Please put a space between your inputs:(ie. 1 3 5)\n" +
                "or if you're happy with you hand hit 'enter':\n");

            string userInput = Console.ReadLine();

            if (userInput == "1 2 3 4 5")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[2] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("\npick another number to reroll\n");
                string x = Console.ReadLine();
                if (x == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (x == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (x == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (x == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (x == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (x == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (x == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (x == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (x == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (x == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (x == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }

            }
            else if (userInput == "1 2 3 4")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[2] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string a = Console.ReadLine();
                if (a == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (a == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (a == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (a == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (a == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (a == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (a == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (a == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (a == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (a == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (a == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 2 3")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[2] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string c = Console.ReadLine();
                if (c == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (c == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (c == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (c == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (c == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (c == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (c == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (c == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (c == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (c == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (c == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 2")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string d = Console.ReadLine();
                if (d == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (d == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (d == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (d == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (d == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (d == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (d == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (d == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (d == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (d == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (d == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1")
            {
                dice[0] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string e = Console.ReadLine();
                if (e == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (e == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (e == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (e == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (e == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (e == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (e == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (e == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (e == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (e == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (e == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2")
            {
                dice[1] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string f = Console.ReadLine();
                if (f == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (f == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (f == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (f == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (f == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (f == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (f == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (f == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (f == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (f == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (f == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 3")
            {
                dice[1] = Reroll();
                dice[2] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string g = Console.ReadLine();
                if (g == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (g == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (g == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (g == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (g == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (g == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (g == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (g == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (g == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (g == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (g == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 3 4")
            {
                dice[1] = Reroll();
                dice[2] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string h = Console.ReadLine();
                if (h == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (h == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (h == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (h == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (h == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (h == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (h == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (h == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (h == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (h == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (h == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 3 4 5")
            {
                dice[1] = Reroll();
                dice[2] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string j = Console.ReadLine();
                if (j == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (j == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (j == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (j == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (j == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (j == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (j == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (j == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (j == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (j == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (j == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "3")
            {
                dice[2] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string k = Console.ReadLine();
                if (k == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (k == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (k == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (k == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (k == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (k == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (k == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (k == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (k == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (k == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (k == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "3 4")
            {
                dice[2] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string l = Console.ReadLine();
                if (l == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (l == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (l == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (l == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (l == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (l == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (l == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (l == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (l == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (l == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (l == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "3 4 5")
            {
                dice[2] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string q = Console.ReadLine();
                if (q == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (q == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (q == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (q == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (q == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (q == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (q == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (q == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (q == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (q == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (q == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "4")
            {
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string w = Console.ReadLine();
                if (w == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (w == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (w == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (w == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (w == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (w == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (w == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (w == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (w == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (w == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (w == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "4 5")
            {
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string r = Console.ReadLine();
                if (r == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (r == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (r == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (r == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (r == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (r == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (r == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (r == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (r == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (r == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (r == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "5")
            {
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string t = Console.ReadLine();
                if (t == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (t == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (t == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (t == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (t == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (t == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (t == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (t == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (t == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (t == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (t == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 3")
            {
                dice[0] = Reroll();
                dice[2] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string y = Console.ReadLine();
                if (y == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (y == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (y == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (y == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (y == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (y == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (y == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (y == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (y == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (y == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (y == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 3 4")
            {
                dice[0] = Reroll();
                dice[2] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string u = Console.ReadLine();
                if (u == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (u == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (u == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (u == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (u == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (u == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (u == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (u == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (u == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (u == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (u == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 3 4 5")
            {
                dice[0] = Reroll();
                dice[2] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string o = Console.ReadLine();
                if (o == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (o == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (o == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (o == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (o == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (o == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (o == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (o == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (o == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (o == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (o == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 2 4")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string p = Console.ReadLine();
                if (p == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (p == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (p == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (p == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (p == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (p == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (p == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (p == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (p == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (p == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (p == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 2 4 5")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string z = Console.ReadLine();
                if (z == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (z == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (z == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (z == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (z == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (z == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (z == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (z == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (z == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (z == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (z == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 2 3 5")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[2] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string v = Console.ReadLine();
                if (v == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (v == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (v == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (v == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (v == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (v == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (v == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (v == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (v == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (v == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (v == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 4")
            {
                dice[1] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string n = Console.ReadLine();
                if (n == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (n == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (n == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (n == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (n == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (n == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (n == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (n == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (n == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (n == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (n == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 4 5")
            {
                dice[1] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string m = Console.ReadLine();
                if (m == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (m == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (m == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (m == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (m == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (m == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (m == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (m == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (m == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (m == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (m == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "3 5")
            {
                dice[2] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string aa = Console.ReadLine();
                if (aa == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (aa == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (aa == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (aa == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (aa == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (aa == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (aa == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (aa == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (aa == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (aa == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (aa == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 4")
            {
                dice[0] = Reroll();
                dice[3] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string bb = Console.ReadLine();
                if (bb == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (bb == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (bb == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (bb == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (bb == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (bb == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (bb == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (bb == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (bb == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (bb == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (bb == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 4 5")
            {
                dice[0] = Reroll();
                dice[3] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string cc = Console.ReadLine();
                if (cc == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (cc == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (cc == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (cc == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (cc == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (cc == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (cc == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (cc == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (cc == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (cc == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (cc == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 5")
            {
                dice[0] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string dd = Console.ReadLine();
                if (dd == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (dd == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (dd == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (dd == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (dd == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (dd == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (dd == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (dd == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (dd == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (dd == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (dd == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 5")
            {
                dice[1] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string ee = Console.ReadLine();
                if (ee == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (ee == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (ee == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (ee == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (ee == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (ee == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (ee == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (ee == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (ee == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ee == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ee == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 3 5")
            {
                dice[0] = Reroll();
                dice[2] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string ss = Console.ReadLine();
                if (ss == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (ss == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (ss == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (ss == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (ss == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (ss == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (ss == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (ss == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (ss == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (ss == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (ss == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "2 3 5")
            {
                dice[1] = Reroll();
                dice[2] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string zz = Console.ReadLine();
                if (zz == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (zz == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (zz == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (zz == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (zz == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (zz == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (zz == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (zz == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (zz == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (zz == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (zz == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            else if (userInput == "1 2 5")
            {
                dice[0] = Reroll();
                dice[1] = Reroll();
                dice[4] = Reroll();
                Dice();
                Console.WriteLine("pick another number to reroll\n");
                string xx = Console.ReadLine();
                if (xx == "1 2 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 2 3 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "1 2 3")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (xx == "1 2")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    Dice();
                }
                else if (xx == "1")
                {
                    dice[0] = Reroll();
                    Dice();
                }
                else if (xx == "2")
                {
                    dice[1] = Reroll();
                    Dice();
                }
                else if (xx == "2 3")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();

                    Dice();
                }
                else if (xx == "2 3 4")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();

                    Dice();
                }
                else if (xx == "2 3 4 5")
                {

                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "3")
                {
                    dice[2] = Reroll();
                    Dice();
                }
                else if (xx == "3 4")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "3 4 5")
                {
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "4")
                {
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "4 5")
                {
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "5")
                {
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 3")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    Dice();
                }
                else if (xx == "1 3 4")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "1 3 4 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 2 4")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "1 2 4 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 2 3 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "2 4")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "2 4 5")
                {
                    dice[1] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "3 5")
                {
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 4")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    Dice();
                }
                else if (xx == "1 4 5")
                {
                    dice[0] = Reroll();
                    dice[3] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 5")
                {
                    dice[0] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "2 5")
                {
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 3 5")
                {
                    dice[0] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "2 3 5")
                {
                    dice[1] = Reroll();
                    dice[2] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
                else if (xx == "1 2 5")
                {
                    dice[0] = Reroll();
                    dice[1] = Reroll();
                    dice[4] = Reroll();
                    Dice();
                }
            }
            
        }



        //Helper Method
        private void WriteRead()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private void PlayerOneRolls(PokerishGame game)
        {
            Console.WriteLine($"{game.PlayerOne} rolls the dice.");
        }

        private int Reroll()
        {
            return RandomNumber.Next(1, 11);
        }

        private void Dice()
        {
            Console.WriteLine($"\n\n 1. {dice[0]}\n 2. {dice[1]}\n 3. {dice[2]}\n 4. {dice[3]}\n 5. {dice[4]}\n");
        }

        private void PlayAgain()
        {
            Console.Clear();

            Console.WriteLine("Roll the dice!\n" +
                "Try to get your best Pokerish Hand!");
            Console.ReadLine();

            TheActualGame();
        }

    }

}
