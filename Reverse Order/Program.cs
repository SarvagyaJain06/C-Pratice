using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {/* This program inputs three letters and displays in reverse order*/

            Console.WriteLine("Enter first latter");
            char first = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter second latter");
            char second = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter third latter");
            char third = char.Parse(Console.ReadLine());

            Console.WriteLine("{2} {1} {0}", first, second, third);
            Console.ReadLine();
        }
    }
}
