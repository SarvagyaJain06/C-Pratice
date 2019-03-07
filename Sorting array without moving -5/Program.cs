using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_array_without_moving__5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program sorts the array in ascending order without moving a particular number -5 */
            int[] numbers = { 7, 5, 3, -5, 8, -5, 37, 9, 0, -1 };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }


            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
