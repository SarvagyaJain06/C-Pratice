using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {/* This program overload two functions */
            Program program = new Program();
            program.Convert(7.5f);
            program.Convert(1);
            program.Convert(7.5);
            program.Convert(8.9);
            Console.ReadLine();

        }

        public void Convert(int num)
        {
            Console.WriteLine("Int");
        }

        public void Convert(double num)
        {
            Console.WriteLine("Double");
        }

        public void Convert(float num)
        {
            Console.WriteLine("float");
        }
    }
}
