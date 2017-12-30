using static System.Console;

namespace ClassesAndGenerics
{
    class LabResearcher : SpaceCadet
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
    }
}
