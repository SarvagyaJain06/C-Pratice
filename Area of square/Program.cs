using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_square
{
    class Program
    {
        static void Main(string[] args)
        {
            float side = float.Parse(Console.ReadLine());
            Square square = new Square(side);
            Console.WriteLine(square.Area());
            Console.ReadLine();
        }
    }
}
