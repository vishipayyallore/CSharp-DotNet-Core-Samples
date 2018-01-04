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
            throw new System.NotImplementedException();
        }

    }
}