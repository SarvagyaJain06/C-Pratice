using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Greater_Than_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
			///hjhuhui
            Console.WriteLine("Enter the number");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int input2 = int.Parse(Console.ReadLine());
            if ((input1 > 200 && input2 < 100) || (input2 > 200 && input1 < 100))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
