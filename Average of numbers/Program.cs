using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            string val1, val2, val3, val4;
            Console.WriteLine("Enter the four numbers:");
            Console.WriteLine("first: ");
            val1 = Console.ReadLine();
            val2 = Console.ReadLine();
            val3 = Console.ReadLine();
            val4 = Console.ReadLine();
            num1 = Convert_To_Integer(val1);
            num2 = Convert_To_Integer(val2);
            num3 = Convert_To_Integer(val3);
            num4 = Convert_To_Integer(val4);
            Average_Of_Integers(num1, num2, num3, num4);
            Console.ReadLine();
        }
        public static int Convert_To_Integer(string input)
        {
            int Integer = int.Parse(input);
            return Integer;
        }

        public static void Average_Of_Integers(int first, int second, int third, int fourth)
        {
            float average;
            average = (first + second + third + fourth) / 4;
            Console.WriteLine(average);
        }
    }
}
