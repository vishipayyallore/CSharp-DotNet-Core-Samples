namespace ClassesAndGenerics
{
    public class LaunchSuttle
    {
        private double _engineThrust;
        private double _totalShuttleMass;
        private double _localGravitationalAccelaration;
        private double _universalGravitationalConstant;

        private const double EarthGravity = 9.81;
        private const double MoonGravity = 1.63;
        private const double MarsGravity = 3.75;

        public LaunchSuttle(double engineThrust, double totalShuttleMass, double localGravitationalAccelaration)
        {
            _engineThrust = engineThrust;
            _totalShuttleMass = totalShuttleMass;
            _localGravitationalAccelaration = localGravitationalAccelaration;
        }

    }
}