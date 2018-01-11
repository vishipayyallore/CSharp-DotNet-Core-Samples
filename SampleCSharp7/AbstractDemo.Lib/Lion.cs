using System;
using Common.Enums;

namespace AbstractDemo.Lib
{
    public class Lion : Cat
    {
        private readonly LionColorSpectrum _bodyColor;

        public Lion(LionColorSpectrum bodyColor)
        {
            _bodyColor = bodyColor;
        }

        public override Cat Eat()
        {
            Console.WriteLine($" The {_bodyColor} lion eats.");
            return this;
        }

        public override Cat Hunt()
        {
            Console.WriteLine($" The {_bodyColor} lion hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            Console.WriteLine($" The {_bodyColor} lion sleeps.");
            return this;
        }
    }

}
