using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Laptop
{
    abstract class Laptop
    {
        protected string _name;
        protected decimal _price;
        protected string _processor;
        protected string _RAM;
        protected string _hardDrive;

        public  abstract void showLaptopInfo();
        
    }
}
