using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_and_lowest_among_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, largest, smallest;
            Console.WriteLine("Enter the first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number : ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                largest = num1;
                if (num2 > num3)
                    smallest = num3;
                else
                    smallest = num2;
            }
            else if (num2 > num1 && num2 > num3)
            {
                largest = num2;
                if (num1 > num3)
                    smallest = num3;
                else
                    smallest = num1;
            }
            else
            {
                largest = num3;
                if (num1 > num2)
                    smallest = num2;
                else
                    smallest = num1;

            }

            Console.WriteLine("smallest: {0} , largest : {1}", smallest, largest);
            Console.ReadLine();
        }
    }
}
