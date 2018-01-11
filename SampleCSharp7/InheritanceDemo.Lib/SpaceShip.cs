using System;

namespace InheritanceDemo.Lib
{
    public class SpaceShip
    {
        public SpaceShip ControlBridge()
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip MedicalBay(int patientCapacity)
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip EngineRoom(int warpDrives)
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip CrewQuarters(int crewCapacity)
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip TeleportationRoom()
        {
            Console.WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}
