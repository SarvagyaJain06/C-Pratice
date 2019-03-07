using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_implementation
{
    class Program
    {
        public abstract class SpaceStation
        {
            int _member = 0;
            public SpaceStation(int num)
            {
                _member = num;
            }
            public abstract void FireLaser();


        }
        public class DeathStar : SpaceStation
        {
            int _id = 0;
            public DeathStar(int a, int b) : base(4)
            {
                _id = a;
            }
            public override void FireLaser()
            {
                Console.WriteLine("Pew pew");
            }

        }

        static void Main(string[] args)
        {
            DeathStar ds = new DeathStar(4, 3);
            ds.FireLaser();
            Console.ReadLine();
        }
    }
}
