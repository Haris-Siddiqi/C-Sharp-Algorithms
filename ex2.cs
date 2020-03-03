using System;

namespace Week3_excercise
{
    /* 
     * Excercise 1
     */
    class ex1
    {
        static void Main(string[] args)
        {
            // Declare variables
            int hen1;
            int hen2;
            int hen3;
            int hen4;
            int total;
            int dozens;
            int singles;

            // Get information from user
            Console.WriteLine("How many eggs did the first hen produce?");
            hen1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many eggs did the second hen produce?");
            hen2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many eggs did the third hen produce?");
            hen3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many eggs did the fourth hen produce?");
            hen4 = Convert.ToInt32(Console.ReadLine());

            // Arithmetic
            total = hen1 + hen2 + hen3 + hen4;
            dozens = total / 12;
            singles = total - (12 * dozens);

            // Display dozens and singles
            Console.WriteLine("There are " + dozens + " dozens and " + singles + " eggs.");
        }
    }
}
