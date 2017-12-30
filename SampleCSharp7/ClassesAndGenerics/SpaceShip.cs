using static System.Console;

namespace ClassesAndGenerics
{
    public class SpaceShip
    {
        public SpaceShip ControlBridge()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip MedicalBay(int patientCapacity)
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip EngineRoom(int warpDrives)
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip CrewQuarters(int crewCapacity)
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip TeleportationRoom()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}
