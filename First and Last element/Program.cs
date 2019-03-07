using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Last_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks wheather first and last elements are same or not: ");
            Console.WriteLine();

            Console.WriteLine("An array of integers: ");
            int[] array = { 1, 2, 5, 66, 56, 99, 1 };

            if (array[0] == array[array.Length - 1])
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}
