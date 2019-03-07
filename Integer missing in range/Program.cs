using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_missing_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 20, 16, 19, 1, 5 };
            int count = 0;
            int difference = 0;
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                difference = numbers[i + 1] - numbers[i];
                if (difference > 1)
                    count = count + difference - 1;
            }
            Console.WriteLine("The count of numbers are {0}", count);
            Console.ReadLine();
        }
    }
}
