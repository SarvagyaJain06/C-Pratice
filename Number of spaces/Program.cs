using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_spaces
{
    class Program
    {
        static void Main(string[] args)
        {/*This program inputs a string and counts the number of spaces.*/
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string[] splittedWords = input.Split(' ');
            int numberOfWords = splittedWords.Length;
            Console.WriteLine("Numeber of spaces are {0}",numberOfWords-1);
            Console.ReadLine();
        }
    }
}
