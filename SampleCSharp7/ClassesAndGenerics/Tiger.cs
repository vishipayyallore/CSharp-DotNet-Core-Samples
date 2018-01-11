using static System.Console;
using Common.Enums;

namespace ClassesAndGenerics
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
            WriteLine($" The {_bodyColor} tiger eats.");
            return this;
        }

        public override Cat Hunt()
        {
            WriteLine($" The {_bodyColor} tiger hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            WriteLine($" The {_bodyColor} tiger sleeps.");
            return this;
        }
    }

}
