using System;

namespace AbstractDemo.Lib
{
    public class NullCat : Cat
    {
        public override Cat Eat()
        {
            Console.WriteLine($" The Unknown cat eats.");
            return this;
        }

        public override Cat Hunt()
        {
            Console.WriteLine($" The Unknown cat hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            Console.WriteLine($" The Unknown cat sleeps.");
            return this;
        }

    }
}
