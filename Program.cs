using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            string player_Choice;
            string comp_Choice;
            int rand_Num;
            string message;

            // generate number
            Random ranNumberGenerator = new Random();
            rand_Num = ranNumberGenerator.Next(1, 4);

            // convert to string
            if (rand_Num == 1)
            {
                comp_Choice = "R";
            }
            else if (rand_Num == 2)
            {
                comp_Choice = "P";
            }
            else
            {
                comp_Choice = "S";
            }

            // player choice
            Console.WriteLine("Rock, paper, scissors!");
            Console.WriteLine("Type 'R' for rock, 'P' for paper, 'S' scissors:");
            player_Choice = Console.ReadLine().ToUpper();


            // if statement
            if (player_Choice == "R")
            {
                if (comp_Choice == "R")
                {
                    message = "Tie game";
                }
                else if (comp_Choice == "P")
                {
                    message = "You lose";
                }
                else
                {
                    message = "You win";
                }
            }
            else if (player_Choice == "P")
            {
                if (comp_Choice == "R")
                {
                    message = "You win";
                }
                else if (comp_Choice == "P")
                {
                    message = "Tie game";
                }
                else
                {
                    message = "You lose";
                }
            }
            else
            {
                if (comp_Choice == "R")
                {
                    message = "You lose";
                }
                else if (comp_Choice == "P")
                {
                    message = "You win";
                }
                else
                {
                    message = "Tie game";
                }
            }

            // output
            Console.WriteLine("\nYour choice: " + player_Choice);
            Console.WriteLine("Computer's choice: " + comp_Choice);
            Console.WriteLine(message);
        }
    }
}
