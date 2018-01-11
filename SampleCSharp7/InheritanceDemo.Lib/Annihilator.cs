using System;
using System.Reflection;

namespace InheritanceDemo.Lib
{
    public class Annihilator : Destroyer
    {
        public Annihilator TractorBeam()
        {
            Console.WriteLine($"-----{GetType().Name}::{MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public Annihilator PlanetDestructionCapability()
        {
            Console.WriteLine($"-----{GetType().Name}::{MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}
