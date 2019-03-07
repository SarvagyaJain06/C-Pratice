using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_first_and_last_char_of_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.WriteLine("enter the string");
            input = Console.ReadLine();
            Swaping_First_and_Last_Char_of_String(input);
            Console.ReadLine();
        }


        public static void Swaping_First_and_Last_Char_of_String(string input)
        {
            string output;
            char first, last;
            first = input[0];
            last = input[input.Length - 1];
            if (input.Length >= 3)
            {
                output = (last + input.Substring(1, (input.Length) - 2) + first);
                Console.WriteLine(output);
            }
            else if (input.Length > 1 && input.Length < 3)
            {
                output = last.ToString() + first.ToString();
                Console.WriteLine(output);

            }
            else
            {
                output = input[0].ToString();
                Console.WriteLine(output);
            }
        }
    }
}
