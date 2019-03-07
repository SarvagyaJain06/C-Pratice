using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_And_Class
{
    class Program
    {/*This program contains a class and a structure assigning values to member variables.*/
        static void Main(string[] args)
        {
            int value1, value2;
            Console.WriteLine("Enter values:");
            value1 = int.Parse(Console.ReadLine());
            value2 = int.Parse(Console.ReadLine());

            Value newValue = new Value(value1, value2);
            newValue.Show();
            ValueClass newValue1 = new ValueClass(value1 + 10, value2 + 10);
            newValue1.Show();
            SetData(newValue1, newValue);


            Console.ReadLine();


        }

        public struct Value
        {
            private int _x;
            private int _y;

            public Value(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public void newMember()
            {
                int _z;
                _z = _x;
                Console.WriteLine(_z);
            }

            public int Modify()
            {
                _x += 100;
                return _x;
            }


            public void Show()
            {
                Console.WriteLine("{0},{1}", _x.ToString(), _y.ToString());
            }
        }
        public class ValueClass
        {
            private int _x, _y;
            public ValueClass(int x, int y)
            {
                _x = x;
                _y = y;
            }
            public void Show()
            {
                Console.WriteLine("{0},{1}", _x, _y);
            }

            public void newMember()
            {
                int _z;
                _z = _x;
                Console.WriteLine(_z);
            }
            public int GetValueX()
            {
                return _x;
            }
            public int GetValueY()
            {
                return _y;
            }
            public int Modify()
            {
                _x += 100;
                return _x;
            }
        }

        static void SetData(ValueClass newValue1, Value newValue)
        {
            int x = newValue1.GetValueX();
            int y = newValue1.GetValueY();

            newValue1.newMember();
            newValue.newMember();

            newValue1.Modify();
            newValue.Modify();


            newValue1.Show();
            newValue.Show();
            newValue1.newMember();
            newValue.newMember();
        }
    }
}

