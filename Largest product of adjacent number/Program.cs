using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_product_of_adjacent_number
{
    class Program
    {
        static void Main(string[] args)
        {  /*This program search for the two consecutive numbers with maximum product in an array*/

            int[] array = { 3, 65, 7, 24, 100, 6, 7, 43, 54, 7, 43, 2 };
            Maximum_Product(array);
            Console.ReadLine();
        }
        public static void Maximum_Product(int[] numbers)
        {
            int product = 0;
            int indexOfNumber = 0;
            int maxProduct = 0;
            int length = numbers.Length;
            for (int i = 0; i < length - 1; i++)
            {
                if (maxProduct < numbers[i] * numbers[i + 1])
                {
                    indexOfNumber = i;
                    maxProduct = numbers[i] * numbers[i + 1];
                }

            }
            Console.WriteLine("Those two numbers are : {0} ,{1}", numbers[indexOfNumber - 1], numbers[indexOfNumber]);
        }
    }
}
