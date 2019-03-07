using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_number_in_a_range
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program is given an Array of integers and asked to find the integers missing in the range of highest and lowest integers*/

            int[] numbers = { 1, 3, 4, 7, 9, 5, 14 };
            int size = numbers.Length;
            Array.Sort(numbers); // sorts array in ascending order.
            int count = 0;

            for (int i = 0; i < size - 1; i++)
            {
                if (numbers[i] != numbers[i + 1]) // eliminates duplicate numbers
                {
                    count = count + numbers[i + 1] - numbers[i] - 1;
                }
            }
            Console.WriteLine("Numbers of elements missing in this range are {0} ", count);
            Console.ReadLine();

        }
    }
}
