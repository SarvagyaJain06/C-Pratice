using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplying_indexes_of_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The product of each same index value o two arrays:");
            int[] array1 = { 2, 4, 6, 8 };
            int[] array2 = { 4, 3, 2, 1 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(array1[i] * array2[i]);
            }
            Console.ReadLine();
        }
    }
}
