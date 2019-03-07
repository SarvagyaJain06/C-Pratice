using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program verifies if a string starts with word 'hi' or not*/
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            Console.WriteLine(doesStartWith_hi(input));
            Console.ReadLine();
        }

        public static bool doesStartWith_hi(string input)
        {
            string[] splittedString = input.Split( new[] { " " }, StringSplitOptions.None);
            if (splittedString[0] == "hi")
            {
                return true;
            }
            else
                return false;
        }
    }
}
