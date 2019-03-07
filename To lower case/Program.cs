using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_lower_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();
            Console.WriteLine(input.ToLower());
            Console.ReadLine();
        }
    }
}
