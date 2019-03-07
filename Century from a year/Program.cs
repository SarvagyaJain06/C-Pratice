using System;

namespace Century_from_a_year
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program inputs a year and return the century*/

            Console.WriteLine("Enter the year : ");
            int year = int.Parse(Console.ReadLine());
            int century = year / 100 + 1;
            Console.WriteLine("Century is : {0}th", century);

            Console.ReadLine();
        }
    }
}
