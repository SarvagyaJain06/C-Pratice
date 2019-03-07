using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_or_last
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks the input number is at the first or last position of a given array or not ");
            int[] integers = { 1, 3, 5, 7, 8, 4, 57, 8, 5, 4, 2, 46, 7 };
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());
            if (integers[0] == input || integers[integers.Length - 1] == input)
                Console.WriteLine("yes it is first or last.");
            else
                Console.WriteLine("No it is niether first nor last.");
            Console.ReadLine();
        }
    }
}
