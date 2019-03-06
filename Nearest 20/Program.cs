using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("This program inputs two number and returns the nearest number to 20 or return '0' if numbers are same");
            Console.WriteLine("Enter the first number :");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(CompareNumberWith20(number1, number2));
            Console.ReadLine();
        }
        public static int CompareNumberWith20(int num1, int num2)
        {
            return (Math.Abs(20 - num1) == Math.Abs(20 - num2)) ? 0 : (Math.Abs(20 - num1) > Math.Abs(20 - num2) ? num2 : num1);
        }
    }
}
