using System;

namespace InheritanceDemo.Lib
{
    public class Destroyer : SpaceShip
    {
        public Destroyer WarRoom()
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public Destroyer Armory(int payloadCapacity)
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public Destroyer WarSpecialists(int activeBattlions)
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}