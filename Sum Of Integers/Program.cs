using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Integers
{
    
     class Program
        {
            static void Main(string[] args)
            {
                int number1, number2;
                Console.WriteLine("Enter two numbers");
                Console.WriteLine("1st: ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2nd: ");
                number2 = int.Parse(Console.ReadLine());

                MagicalSum(number1, number2);
                Console.ReadLine();
            }
            static void MagicalSum(int num1, int num2)
            {
                if (num1 == num2)
                    Console.WriteLine(3 * (num1 + num2));
                else
                    Console.WriteLine(num1 + num2);
            }
        }
    }
 

