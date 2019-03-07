using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_sum_or_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter two numbers");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(num1, num2));
            Console.ReadLine();
        }
        static bool Check(int num1, int num2)
        {
            if ((num1 == 20 || num2 == 20) || (num1 + num2 == 20))
                return true;
            else
                return false;
        }
    }
}
