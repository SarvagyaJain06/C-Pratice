using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 sum = 0;
            int count = 0;
            Int64 number = 2;
            while (count < 500)
            {

                if (isPrime(number))
                {

                    sum += number;
                    count++;
                }
                number++;
            }

            Console.WriteLine("The sum of first 500 Prime numbers is : {0}", sum);
            Console.ReadLine();
        }
        public static bool isPrime(Int64 num)
        {
            if (num == 2)
                return true;

            for (Int64 i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
