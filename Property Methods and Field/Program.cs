using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Methods_and_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeType oneType = new SomeType();
            oneType.setValue(10, "red");
            oneType.getValue();
            Console.ReadLine();
        }
        public struct SomeType
        {

            private int _marks;
            private string _color;

            public void setValue(int mark,string color)
            {
                _marks = mark;
                _color = color;
            }
            public void getValue()
            {
                Console.WriteLine("{0}, {1}",_marks, _color);
            }
        }
    }
}
