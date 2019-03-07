using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_of_integers_in_left_direction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shifts the array in left direction by one position.");
            Console.WriteLine();
            int[] array = { 3, 5, 9, 10, 25, 6 };
            int[] newArray = shiftArray(array);

            foreach (var item in newArray)
            {
                Console.Write(item + " ");

            }

            Console.ReadLine();

        }
        public static int[] shiftArray(int[] array)
        {
            int[] shift = new int[6];
            int i;
            for (i = 0; i < 5; i++)
            {
                shift[i] = array[i + 1];
            }
            shift[i] = array[0];
            return shift;
        }
    }
}

