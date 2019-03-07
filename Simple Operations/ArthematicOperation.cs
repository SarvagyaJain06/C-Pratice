using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Operations
{
    class ArthematicOperation
    {
        public float Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public float Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        public float Remainder(int num1, int num2)
        {
            return num1 % num2;
        }

    }
}
