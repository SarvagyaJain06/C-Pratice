using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_character_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program inputs a string and finds odd index element out into another string and displays it.");
            Console.WriteLine();
            Console.WriteLine("Enter the string : ");
            string input = Console.ReadLine();
            string output = null;
            int lengthOfString = input.Length;
            for (int i = 0; i < lengthOfString; i++)
            {
                if (i % 2 == 0)
                    output += input[i];

            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
