using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number < 100)
            {
                if (number % 2 != 0)
                    Console.WriteLine(number);

                number++;
            }

            Console.ReadLine();
        }
    }
}
