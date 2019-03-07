using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Operations
{
    class Program
    {
        
            static void Main(string[] args)
            {
                ArthematicOperation arthematicOperation = new ArthematicOperation();
                float sum = arthematicOperation.Add(4, 5);
                Console.WriteLine(sum);
                float substraction = arthematicOperation.Substract(5, 3);
                Console.WriteLine(substraction);
                float multiplication = arthematicOperation.Multiplication(4, 5);
                Console.WriteLine(multiplication);
                float division = arthematicOperation.Division(5, 3);
                Console.WriteLine(division);
                float remainder = arthematicOperation.Remainder(7, 3);
                Console.WriteLine(remainder);
                Console.ReadLine();
            }
        
    }
}
