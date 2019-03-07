using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_intialization_without_new_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson;
            newPerson.name = "Any name";
            newPerson.age = 18;

        }


        struct Person
        {
            public string name;
            public int age;
        };
    }
}
