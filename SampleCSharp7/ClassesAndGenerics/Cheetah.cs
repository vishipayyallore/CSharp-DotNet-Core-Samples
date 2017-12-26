using static System.Console;

namespace ClassesAndGenerics
{
    public class Cheetah : Cat, IPurrable
    {

        public void SoftPurr(int decibel)
        {
            WriteLine($" The {nameof(Cheetah)} purrs at {decibel} decibels.");
        }

        public override Cat Eat()
        {
            WriteLine($" The cheetah eats.");
            return this;
        }

        public override Cat Hunt()
        {
            WriteLine($" The cheetah hunts.");
            return this;
        }

        public override Cat Sleep()
        {
            WriteLine($" The cheetah sleeps.");
            return this;
        }
        
    }
}
