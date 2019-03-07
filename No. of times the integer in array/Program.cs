using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No.of_times_the_integer_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of times a number is present in an array of integers.");
            Console.Write("array of integers : ");
            int[] integers = { 4, 5, 6, 7, 4, 2, 5, 6, 2, 4 };
            foreach (int num in integers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            int number, count = 0;
            Console.WriteLine("Enter the number you want to find : ");
            number = int.Parse(Console.ReadLine());
            foreach (int integer in integers)
            {
                if (integer == number)
                    count++;
            }
            Console.WriteLine("The number of times {0} present in array is {1}.", number, count);

            Console.ReadLine();
        }
    }
}
