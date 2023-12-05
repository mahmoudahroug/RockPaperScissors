using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredText("Rock Paper Scissors Created by Mahmoud", ConsoleColor.Blue);
            while(true)
            {
                string[] rps = { "rock", "paper", "scissors" };
                // defining a Random to choose a move
                Random x = new Random();
                int xNum = x.Next(0, 3);

                Console.Write("Choose your move:");
                string move = "";

                bool badinput = true;
                while(badinput)
                {
                    move = Console.ReadLine();
                    move.ToLower();
                    if (move == "rock" || move == "paper" || move == "scissors")
                    {
                        badinput = false;
                    }
                    else
                    {
                        ColoredText("Please enter one of the following:\"rock, paper, scissors\"", ConsoleColor.DarkRed);
                    }
                }
                Console.WriteLine("The computer chose "+ rps[xNum]);
                if(rps[xNum] == "rock")
                {
                    switch (move)
                    {
                        case "rock":
                            ColoredText("It's a draw!!", ConsoleColor.DarkYellow);
                            break;
                        case "paper":
                            ColoredText("You won!!", ConsoleColor.Green);
                            break;
                        case "scissors":
                            ColoredText("You lost!!", ConsoleColor.Red);
                            break;
                    }
                }
                else if(rps[xNum] == "paper")
                {
                    switch (move)
                    {
                        case "paper":
                            ColoredText("It's a draw!!", ConsoleColor.DarkYellow);
                            break;
                        case "scissors":
                            ColoredText("You won!!", ConsoleColor.Green);
                            break;
                        case "rock":
                            ColoredText("You lost!!", ConsoleColor.Red);
                            break;
                    }
                }
                else if(rps[xNum] == "scissors")
                {
                    switch (move)
                    {
                        case "scissors":
                            ColoredText("It's a draw!!", ConsoleColor.DarkYellow);
                            break;
                        case "rock":
                            ColoredText("You won!!", ConsoleColor.Green);
                            break;
                        case "paper":
                            ColoredText("You lost!!", ConsoleColor.Red);
                            break;
                    }
                }
                Console.WriteLine("Play again?Y/N");
                string play = Console.ReadLine();
                if (play.ToUpper() != "Y")
                {
                    break;
                }
            }

        }
        public static void ColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
