using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_Character_at_start_and_at_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            input = "T" + input + "T";
            Console.Write(input);

            Console.ReadLine();
        }
    }
}
