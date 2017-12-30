using static System.Console;

namespace ClassesAndGenerics
{
    public class PlanetExplorer : SpacePrivate
    {
        public override void ChartingStarMaps()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }

        public override void BasicCommunicationSkill()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }

        public override void BasicWeaponsTraining()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }

        public override void Negotiation()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }

        public override void AdvancedCommunicationSkill()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }

        public override void AdvancedWeaponsTraining()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }

        public override void Persuader()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
        }
    }
}