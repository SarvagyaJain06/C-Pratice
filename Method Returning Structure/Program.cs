using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Returning_Structure
{
    class Program
    { /*This code is incomplete.*/
        static void Main(string[] args)
        {
            Dimension rectangle = new Dimension(4, 5);
            rectangle.GetDimession(rectangle);
            Console.ReadLine();
        }
 
       public struct Dimension
            {
                private double _length, _breadth;
                public Dimension(double length, double breadth)
                {
                    _length = length;
                    _breadth = breadth;
                }
                public Dimension GetDimession(Dimension D)
                {
                    return D;
                }
            public double area(double length, double breadth)
            {
                double area = length * breadth;
                return area;
            }
        }
    }
}
