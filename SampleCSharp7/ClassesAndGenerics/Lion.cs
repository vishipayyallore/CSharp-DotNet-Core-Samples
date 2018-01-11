using static System.Console;
using Common.Enums;

namespace ClassesAndGenerics
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
            WriteLine($" The {_bodyColor} lion eats.");
            return this;
        }

        public override Cat Hunt()
        {
            WriteLine($" The {_bodyColor} lion hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            WriteLine($" The {_bodyColor} lion sleeps.");
            return this;
        }
    }

}
