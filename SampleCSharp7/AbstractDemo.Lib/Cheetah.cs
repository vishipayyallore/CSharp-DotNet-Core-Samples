using System;

namespace AbstractDemo.Lib
{
    public class Cheetah : Cat, IPurrable
    {

        public void SoftPurr(int decibel)
        {
            Console.WriteLine($" The {nameof(Cheetah)} purrs at {decibel} decibels.");
        }

        public override Cat Eat()
        {
            Console.WriteLine($" The cheetah eats.");
            return this;
        }

        public override Cat Hunt()
        {
            Console.WriteLine($" The cheetah hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            Console.WriteLine($" The cheetah sleeps.");
            return this;
        }
        
    }
}
