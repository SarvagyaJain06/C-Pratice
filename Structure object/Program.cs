using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string nameFirst = Console.ReadLine();

            Console.WriteLine("Enter day of birth: ");
            int dayFirst = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month of birth: ");
            int monthFirst = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year of birth: ");
            int yearFirst = int.Parse(Console.ReadLine());
            string dateOfBirthFirst = dayFirst.ToString() + "-" + monthFirst.ToString() + "-" + yearFirst.ToString();

            Console.WriteLine("Enter name: ");
            string nameSecond = Console.ReadLine();

            Console.WriteLine("Enter day of birth: ");
            int daySecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month of birth: ");
            int monthSecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year of birth: ");
            int yearSecond = int.Parse(Console.ReadLine());
            string dateOfBirthSecond = daySecond.ToString() + "-" + monthSecond.ToString() + "-" + yearSecond.ToString();

            Employee_Data employeeFirst = new Employee_Data();
            Employee_Data.Name employeeFirstName = new Employee_Data.Name(nameFirst);
            Employee_Data.Name employeeDateOfBirthFirst = new Employee_Data.Name(dateOfBirthFirst);

            Employee_Data employeeSecond = new Employee_Data();
            Employee_Data.Name employeeSecondName = new Employee_Data.Name(nameSecond);
            Employee_Data.Name employeeDateOfBirthSecond = new Employee_Data.Name(dateOfBirthSecond);
            employeeFirst.show();
            employeeSecond.show();

            Console.ReadLine();
        }

        public struct Employee_Data
        {
            static string employeeName;

            static string employeeDateOfBirth;
            public struct Name
            {

                public Name(string name)
                {
                    employeeName = name;
                }
            }

            public struct DateOfBirth
            {

                public DateOfBirth(string dateOfBirth)
                {
                    employeeDateOfBirth = dateOfBirth;
                }

            }

            public void show()
            {
                Console.WriteLine(employeeName + Environment.NewLine + employeeDateOfBirth);

            }
        }
    }
}
