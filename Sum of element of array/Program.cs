using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_element_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program counts the sum of a given array");
            Console.WriteLine();
            int sum = 0;
            int[] Array = { 4, 5, 3, 5, 7, 97, 5, 4 };
            foreach (int item in Array)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
