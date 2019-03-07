using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_of_3_or__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 || num % 7 == 0)
                Console.WriteLine("number is divisible by 3 or 7");
            else
                Console.WriteLine("Number is not divisible by 3 and 7");

            Console.ReadLine();
        }
    }
}
