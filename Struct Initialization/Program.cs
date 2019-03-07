using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Initialization
{
    class Program
    {/*Struct is intialized using default and parameterized constructor*/
        static void Main(string[] args)
        {
            Person ravi = new Person("Ravi", "Kumar");

        }

        struct Person
        {
            private string _name;
            private string _surname;
            public Person(string name, string surname)
            {
                _name = name;
                _surname = surname;
            }

        }
    }
}
