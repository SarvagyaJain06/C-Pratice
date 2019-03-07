using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenating_String_and_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string message = "You look older than ";
            Console.WriteLine("Enter the age : ");
            // age = Convert.ToInt32(Console.ReadLine());
            //using ToInt32 will return 0 for null string
            //using int.Parse will return null to null string
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("\"" + message + age + "\"");
            Console.ReadLine();
        }
    }
}
