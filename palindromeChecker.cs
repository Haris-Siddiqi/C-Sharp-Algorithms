using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6
{
    class Program
    {
        // Checks if value is palindrome
        public static bool IsPalindrome(char[] x)
        {
            if (x.Length == 1)
            {
                return true;
            }
            else
            {
                Int32 a = 0;
                Int32 b = (x.Length - 1);
                while (a < b)
                {
                    if (x[a] != x[b])
                    {
                        return false;
                    }
                    a += 1;
                    b -= 1;
                }
                return true;
            }
        }

        // Checks if string is numeric
        public static bool isNumeric(string x)
        {
            return int.TryParse(x, out int n);
        }

        static void Main(string[] args)
        {
            // intro
            Console.WriteLine("******************** Palindrome Checker ********************");
            Console.WriteLine();
            Console.WriteLine("This program checks if your input is a palindrome or not.");
            Console.WriteLine("Here are some examples:");
            Console.WriteLine();
            Console.WriteLine("character palindrome    number palindrome");
            Console.WriteLine("racecar                 1100011");
            Console.WriteLine("abc121cba               99899");
            Console.WriteLine("************************************************************");

            // var
            bool flag = false;
            string[] palindromeList;
            palindromeList = new string[0];

            // loop until input is "end"
            while (flag == false)
            {
                // get input (numbers or characters)
                Console.WriteLine();
                Console.Write("Please enter your input. Enter 'end' to exit: ");
                string userInputString = Convert.ToString(Console.ReadLine());

                // exit loop if input is end
                if (userInputString == "end")
                {
                    flag = true;
                }
                else
                {
                    // check if input is numeric
                    bool inputIsNum = false;
                    if (isNumeric(userInputString))
                    {
                        inputIsNum = true;
                    }

                    // convert to array and check if palindrome
                    char[] userInputChar = userInputString.ToCharArray();
                    bool inputIsPalindrome = IsPalindrome(userInputChar);

                    // add to array if palindrome
                    if (inputIsPalindrome == true)
                    {
                        Array.Resize(ref palindromeList, palindromeList.Length + 1);
                        palindromeList[palindromeList.GetUpperBound(0)] = userInputString;
                    }

                    // display numpal/charpal/notpal
                    if (inputIsNum && inputIsPalindrome)
                    {
                        Console.WriteLine("Your input is a number palindrome.");
                    }
                    else if (inputIsPalindrome)
                    {
                        Console.WriteLine("Your input is a character palindrome.");
                    }
                    else
                    {
                        Console.WriteLine("Your input is not a palindrome.");
                    }
                }
            }

            // ending message
            Console.WriteLine();
            Console.WriteLine("************************************************************");

            // exit loop and print palindrome list
            if (palindromeList.Length > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Here is a list of your palindromes:");
                foreach (var item in palindromeList)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();     
            
        }
    }
}
