using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStructure ss = new SimpleStructure(10, 20);
            ss.Sum();


            Console.ReadLine();
        }

        public struct SimpleStructure
        {
            private int x;
            private int y;

            public SimpleStructure(int num1, int num2)
            {
                x = num1;
                y = num2;

            }

            public void Sum()
            {
                int sum = x + y;
                Console.WriteLine(sum);

            }
        }
    }
}
