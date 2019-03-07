using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular_Matrix_Element_Sum
{
    class Program
    {
        static void Main(string[] args)
        { /* This program contains a matrix and returns the sum of element except the number below zero.*/

            int requiredSum = 0;


            int[,] Matrix = new int[3, 4] { { 0, 2, 3, 2 }, { 0, 6, 0, 1 }, { 4, 0, 3, 0 } };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 2)
                    {
                        if (Matrix[i, j] == 0)
                        {
                            Matrix[i + 1, j] = 0;
                        }
                        requiredSum += Matrix[i, j];
                    }
                    else
                    {
                        requiredSum += Matrix[i, j];
                    }
                }
            }
            Console.WriteLine(requiredSum);
            Console.ReadLine();
        }
    }
}
