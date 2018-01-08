using static System.Console;

namespace Polymorphism.Lib
{
    public class NasaShuttle : Shuttle
    {

        public NasaShuttle(double engineThrust, double totalShuttleMass, double gravitationalAcceleration)
        {
            
        }

        public NasaShuttle(double engineThrust, double totalShuttleMass, 
            double planetMass, double planetRadius)
        {
            
        }

        public override double Twr()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return 0.0;
        }

    }
}