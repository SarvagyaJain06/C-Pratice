using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaDecimal_into_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {//need to do something else
            Console.WriteLine("Enter a Hexadecimal number");
            string hexaValue = Console.ReadLine();
            try
            {
                double decValue = int.Parse(hexaValue, System.Globalization.NumberStyles.HexNumber);
                Console.WriteLine(decValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a proper number.{0}", ex);
            }

            Console.ReadLine();
        }

    }
}
