using static System.Console;
using static System.Reflection.MethodBase;

namespace ClassesAndGenerics
{
    public class Annihilator : Destroyer
    {
        public Annihilator TractorBeam()
        {
            WriteLine($"-----{GetType().Name}::{GetCurrentMethod().Name}()-----");
            return this;
        }

        public Annihilator PlanetDestructionCapability()
        {
            WriteLine($"-----{GetType().Name}::{GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}
