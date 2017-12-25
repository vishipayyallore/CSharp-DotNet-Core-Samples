using static System.Console;

namespace ClassesAndGenerics
{
    public class NullCat : Cat
    {
        public override Cat Eat()
        {
            WriteLine($" The Unknown cat eats.");
            return this;
        }

        public override Cat Hunt()
        {
            WriteLine($" The Unknown cat hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            WriteLine($" The Unknown cat sleeps.");
            return this;
        }

    }
}
