using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_araay_element_in_reverse_order
{
    class Program
    {/*This program displays an array elements into reverse order.*/
        static void Main(string[] args)
        {
            int[] numbers = {1,1,5,6,5,8,8,9};
            for(int i = numbers.Length-1;i>=0;i--)
            {
                Console.WriteLine("{0}",numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
