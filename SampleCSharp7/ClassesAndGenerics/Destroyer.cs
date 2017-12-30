using static System.Console;

namespace ClassesAndGenerics
{
    public class Destroyer : SpaceShip
    {
        public Destroyer WarRoom()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public Destroyer Armory(int payloadCapacity)
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public Destroyer WarSpecialists(int activeBattlions)
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}