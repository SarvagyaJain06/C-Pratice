using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This program forms a laptop with certain specifications using inheritance.*/
            Lenovo lenovo = new Lenovo("Lenovo",1000,"i3","2GB","500GB");
            lenovo.showLaptopInfo();
            Dell dell = new Dell("Dell",1500,"i5","4GB","1TB");
            dell.showLaptopInfo();
            Console.ReadLine();
        }
    }
}
