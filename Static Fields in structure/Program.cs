using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Fields_in_structure
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Enter first number : ");

            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("input vaslures aere a={0}, b={1}", a, b);

            SimpleStructure strc = new SimpleStructure(a, b);
            strc.sum();

            Console.ReadLine();



        }


        public struct SimpleStructure
        {
            static int x;
            static int y;

            public SimpleStructure(int a, int b)
            {
                x = a;
                y = b;

            }
            public void sum()
            {
                int sum = x + y;
                Console.WriteLine(sum);
            }
        }
    }
}

