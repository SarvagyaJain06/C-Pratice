using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Absolute_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the numbers for absolute difference");
            Console.WriteLine("1st: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd: ");
            num2 = int.Parse(Console.ReadLine());
            Magical_Absolute_Difference(num1, num2);
            Console.ReadLine();
        }
        static void Magical_Absolute_Difference(int num1, int num2)
        {
            int difference;
            difference = num1 > num2 ? (num1 - num2) * 2 : Math.Abs(num1 - num2);
            Console.WriteLine(difference);
        }
    }
}
