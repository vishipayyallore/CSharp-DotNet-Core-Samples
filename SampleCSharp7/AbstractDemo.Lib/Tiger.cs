using System;
using Common.Enums;

namespace AbstractDemo.Lib
{
    public class Tiger : Cat
    {
        private readonly TigerColorSpectrum _bodyColor;

        public Tiger(TigerColorSpectrum bodyColor)
        {
            _bodyColor = bodyColor;
        }

        public override Cat Eat()
        {
            Console.WriteLine($" The {_bodyColor} tiger eats.");
            return this;
        }

        public override Cat Hunt()
        {
            Console.WriteLine($" The {_bodyColor} tiger hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            Console.WriteLine($" The {_bodyColor} tiger sleeps.");
            return this;
        }
    }

}
