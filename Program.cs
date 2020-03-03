using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare var
            string user1;
            string user2;

            // get user 1
            Console.WriteLine("Welcome to Rock, Paper, Scissors!\n\n");
            Console.WriteLine("Enter 'r' for rock, 'p' for paper, and 's' for scissors.");
            Console.WriteLine("Please enter Player 1's selection: ");
            user1 = Console.ReadLine().ToLower();

            // get user 2
            Console.WriteLine("Please enter Player 2's selection: ");
            user2 = Console.ReadLine().ToLower();

            // compare and get winner
            if ((user1 == "r" || user1 == "s" || user1 == "p") && (user2 == "r" || user2 == "s" || user2 == "p"))
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }
        }
    }
}
