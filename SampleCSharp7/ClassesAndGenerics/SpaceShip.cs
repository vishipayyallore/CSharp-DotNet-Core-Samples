using static System.Console;

namespace ClassesAndGenerics
{
    public class SpaceShip
    {
        public SpaceShip ControlBridge()
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip MedicalBay(int patientCapacity)
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip EngineRoom(int warpDrives)
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip CrewQuarters(int crewCapacity)
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

        public SpaceShip TeleportationRoom()
        {
            WriteLine($"-----{this.GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return this;
        }

    }
}
