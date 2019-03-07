using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_four_characters_of_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program inputs a string and returns a string by converting first four character into lower case and if the string is less than 4 character it converts it into upper case");
            string output = null;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();

            int lengthOfString = input.Length;
            if (lengthOfString < 4)
            {
                Console.WriteLine(input.ToUpper());
            }
            else
            {
                char[] characters = input.ToCharArray();
                for (int i = 0; i < characters.Length; i++)
                {
                    if (i <= 4)
                    {
                        output += characters[i].ToString().ToLower();
                    }
                    else
                    {
                        output += characters[i].ToString();

                    }

                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
