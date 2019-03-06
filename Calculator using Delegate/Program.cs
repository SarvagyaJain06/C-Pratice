using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_using_Delegate
{
    class Program
    {
        public delegate float Calculator (float num1, float num2);

        public static float  Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Substract (float num1 , float num2)
        {
            return num1 - num2;
        }
         
        public static float Multiply (float num1 ,float num2)
        {
            return num1 * num2;
        }

        public static float Divide (float num1,float num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
         // Delegate handling events.
            Calculator addition = new Calculator(Add);
            Console.WriteLine(addition(5,6));
            Calculator substraction = new Calculator(Substract);
            Console.WriteLine(substraction(9, 3));
            Calculator multiplication = new Calculator(Multiply);
            Console.WriteLine(multiplication(2,3));
            Calculator division = new Calculator(Divide);
            Console.WriteLine(division(8, 2));
            
            // Assigning a method(Substract) to a variable(variable)
            Calculator variable = Substract;
            Console.WriteLine(variable(10, 10));
            Console.ReadLine();
        }
    }
}
