using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copying_Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of elements in an array : ");
            int numberOfElement = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[numberOfElement];
            int[] copiedArray = new int[numberOfElement];
            Console.WriteLine("Enter numbers:");
            for (int i = 0;i<numberOfElement;i++)
            {
                arrayOfNumbers[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0;i<numberOfElement;i++)
            {
                copiedArray[i] = arrayOfNumbers[i];
            }
            Console.Write("Copied array is:(");
            foreach(int item in copiedArray)
            {
                Console.Write("{0},",item);
            }
            Console.Write(")");
            Console.ReadLine();
        }
    }
}
