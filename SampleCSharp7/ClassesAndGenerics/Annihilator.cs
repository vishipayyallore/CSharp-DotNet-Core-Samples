using static System.Console;

namespace ClassesAndGenerics
{
    public class Annihilator : Destroyer
    {
        public Annihilator TractorBeam()
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public Annihilator PlanetDestructionCapability()
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}
