using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_numbers_in_array
{
    class Program
    {/*This program inputs an array and returns the total numbers of duplicate integers.*/ 

        //Incomplete.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of element in array:");
            int numberOfElement = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[numberOfElement];
            for(int i =0;i<numberOfElement;i++)
            {
                Console.WriteLine("Enter element:");
                numbersArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(NumberOfDuplicateIntegers(numbersArray));

            Console.ReadLine();
        }
        public static int NumberOfDuplicateIntegers(int[] array)
        {
            int k = 0;
          
            int[] duplicateInteger = new int[array.Length];
            duplicateInteger[0] = 0;
            for(int i=0;i<array.Length;i++)
            {
                for (int j = i +1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        foreach (int items in duplicateInteger)
                        {
                            if (array[i] != items)
                            {
                                duplicateInteger[k] = array[i];
                                k++;
                            }
                            break;

                        }
                    }
                }
            }
            return k;
        }
    }
}
