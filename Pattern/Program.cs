using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {/*This program input an integer and a width also an integer and draw a triangle with decreasing width*/
            int inte = Console.Read();
            Console.ReadKey();
            Console.WriteLine("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a width : ");
            int width = int.Parse(Console.ReadLine());

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i > j)
                        Console.Write(number);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
