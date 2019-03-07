using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pslindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This program inputs a string and check if it is "Palindrome" or not, hence return true or false accordingly */
            Console.WriteLine("Enter a string and i will tell you if it is \"Palindrome\"");

            string input = Console.ReadLine();
            Console.WriteLine(isPalindrome(input));
            Console.ReadLine();
        }
        public static bool isPalindrome(string input)
        {
            int length = input.Length;
            for (int i = 0; i < (length / 2); i++)
            {
                if (input[i] != input[length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
