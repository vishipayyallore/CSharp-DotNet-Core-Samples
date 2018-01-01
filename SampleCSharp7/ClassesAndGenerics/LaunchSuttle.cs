using System;

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

        public LaunchSuttle(double engineThrust, double totalShuttleMass, Planet planet)
        {
            _engineThrust = engineThrust;
            _totalShuttleMass = totalShuttleMass;
            SetGraviationalAccelaration(planet);
        }

        public LaunchSuttle(double engineThrust, double totalShuttleMass, double planetMass, double planetRadius)
        {
            _engineThrust = engineThrust;
            _totalShuttleMass = totalShuttleMass;
            SetUniversalGravitationalConstant();

            _localGravitationalAccelaration =
                Math.Round((double)CalculateGravitationalAcceleration(planetRadius, planetMass), 2);
        }

        private decimal CalculateGravitationalAcceleration(double planetRadius, double planetMass)
        {
            throw new NotImplementedException();
        }

        private decimal CalculateGravitationalAcceleration()
        {
            throw new NotImplementedException();
        }

        private void SetUniversalGravitationalConstant()
        {
            throw new System.NotImplementedException();
        }

        private void SetGraviationalAccelaration(Planet planet)
        {
            switch (planet)
            {
                case Planet.Earth:
                    _localGravitationalAccelaration = EarthGravity;
                    break;
                case Planet.Moon:
                    _localGravitationalAccelaration = MoonGravity;
                    break;
                case Planet.Mars:
                    _localGravitationalAccelaration = MarsGravity;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(planet), planet, null);
            }
        }

    }
}