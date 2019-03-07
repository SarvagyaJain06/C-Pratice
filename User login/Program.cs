using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_login
{
    class Program
    {
        static void Main(string[] args)
        {/*This program inputs user ID and password from user and reject user after three attemps*/
            string id = "sar@vag";
            string pass = "sarv";

            for (int availableAttempt = 3; availableAttempt > 0;)
            {

                Console.WriteLine("Enter user id : ");
                string userId = Console.ReadLine();
                Console.WriteLine("Enter password : ");
                Console.WriteLine("hint : *password is a string.");
                string password = Console.ReadLine();
                if (userId == id && password == pass)
                {
                    Console.WriteLine("Congratualtion you logged in");
                    break;
                }
                else
                {
                    availableAttempt--;
                    Console.WriteLine("Wrong id password, you left with {0} attemps", availableAttempt);
                }
            }

            Console.ReadLine();
        }
    }
}
