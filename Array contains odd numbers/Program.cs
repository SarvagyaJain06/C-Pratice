using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_contains_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        { /*This program checks weather an array contains odd number or not */
            int[] numbers = { 4, 2, 6, 7, 8 };
            Console.WriteLine(ContainsOddNumber(numbers));
            Console.ReadLine();
        }
        public static bool ContainsOddNumber(int[] numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
