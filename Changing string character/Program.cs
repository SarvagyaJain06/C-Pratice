using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changing_string_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "test";//Console.ReadLine();
            string input1 = "test";// "test";
            char a = 'A';
            int b = 5;
            Program p = new Program();
            Console.WriteLine(a.GetHashCode());

            //Console.Write("\n" + input.Replace("e", "f"));
            //Console.Write("\n"+input.Clone());
            //Console.Write("\n"+input1.GetHashCode() + "\n" + input.GetHashCode());
            //Console.Write("\n" + a.GetHashCode() + "\n" + b.GetHashCode());
            //Console.WriteLine( input.AsMemory());
            Console.ReadLine();
        }
    }
}
