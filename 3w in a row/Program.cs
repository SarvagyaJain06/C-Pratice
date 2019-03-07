using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3w_in_a_row
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program inputs a string and verify if the string starts with 'w' and followed by \"ww\" if yes than returns false.");
            Console.WriteLine("Enter the string : ");


            string input = Console.ReadLine();

            if (input[0] == 'w')
            {
                if (input[1] == 'w' && input[2] == 'w')
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
            else
                Console.WriteLine("true");
            Console.ReadLine();

        }
    }
}
