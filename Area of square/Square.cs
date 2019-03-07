using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_square
{
    public class Square : Shape
    {
        float _side;
        public Square(float side)
        {
            _side = side;
        }
        public override float Area()
        {
            float area = _side * _side;
            return area;
        }
    }
}
