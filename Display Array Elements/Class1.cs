using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Array_Elements
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of elements in a array:");
            int number = int.Parse(Console.ReadLine());
            int[] numberArray = new int[number];
 
            for(int i = 0;i<number;i++)
            {
                Console.WriteLine("Enter element:");
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            foreach ( int element in numberArray)
            {
                Console.WriteLine("{0}", element);
            }
            Console.ReadLine();
        }
    }
}
