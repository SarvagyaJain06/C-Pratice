using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
  
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number dude");
                string value = Console.ReadLine();
                int number = Convert.ToInt32(value);
                MultiplicationTable(number);
                Console.ReadLine();
            }

            public static void MultiplicationTable(int num)
            {
                int i = 1;
                int result = 0;
                for (i = 1; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine("{0} * {1} = {2}", num, i, result);

                }
            }
        
    }
}
