using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int integer = int.Parse(Console.ReadLine());

            SumOfDigit(integer);

            Console.ReadLine();

        }
        public static void SumOfDigit(int integer)
        {
            int sum = 0;

            while (integer != 0)
            {

                int remainder = integer % 10;
                sum += remainder;
                integer = integer / 10;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
