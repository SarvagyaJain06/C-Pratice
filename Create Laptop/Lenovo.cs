using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Laptop
{
    class  Lenovo : Laptop
    {

        public Lenovo(string name,decimal price,string processor,string RAM,string hardDrive)
        {
            _name = name;
            _price = price;
            _processor = processor;
            _RAM = RAM;
            _hardDrive = hardDrive;
        }
        public override void showLaptopInfo()
        {
            Console.WriteLine("{0},{1},{2},{3},{4}",_name,_price,_processor,_RAM,_hardDrive);

        }



    }
}
