using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_character_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program inputs a string and checks if a character is 1 to 3 times or not and returns boolean");

            Console.WriteLine("Enter the string : ");
            string input = Console.ReadLine();
            char ch = 'w';
            int count = 0;
            int i = 0;
            while (i < input.Length)
            {
                if (input[i] == ch)
                    count++;
                i++;
            }
            if (1 <= count && count <= 3)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}
