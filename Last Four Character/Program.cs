using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Four_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            string newString = CopiesFourTimes(input);
            for (int j = 0; j < 4; j++)
            {
                Console.Write(newString);

            }
            Console.ReadLine();
        }

        public static string CopiesFourTimes(string input)
        {
            string newString = null;
            if (input.Length <= 4)
            {
                return input;
            }
            else
            {
                int i = 4;
                while (i > 0)
                {
                    newString += input[input.Length - i];
                    i--;
                }

                return newString;
            }
        }
    }
}

