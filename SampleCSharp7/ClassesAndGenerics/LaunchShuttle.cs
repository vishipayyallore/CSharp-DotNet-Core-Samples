using System;
using Common.Enums;

namespace ClassesAndGenerics
{
    public class LaunchShuttle
    {
        private double _engineThrust;
        private double _totalShuttleMass;
        private double _localGravitationalAccelaration;
        private double _universalGravitationalConstant;

        private const double EarthGravity = 9.81;
        private const double MoonGravity = 1.63;
        private const double MarsGravity = 3.75;

        public LaunchShuttle(double engineThrust, double totalShuttleMass, double localGravitationalAccelaration)
        {
            _engineThrust = engineThrust;
            _totalShuttleMass = totalShuttleMass;
            _localGravitationalAccelaration = localGravitationalAccelaration;
        }

        public LaunchShuttle(double engineThrust, double totalShuttleMass, Planet planet)
        {
            _engineThrust = engineThrust;
            _totalShuttleMass = totalShuttleMass;
            SetGraviationalAccelaration(planet);
        }

        public LaunchShuttle(double engineThrust, double totalShuttleMass, double planetMass, double planetRadius)
        {
            _engineThrust = engineThrust;
            _totalShuttleMass = totalShuttleMass;
            SetUniversalGravitationalConstant();

            _localGravitationalAccelaration =
                Math.Round(CalculateGravitationalAcceleration(planetRadius, planetMass), 2);
        }

        private double CalculateThrustToWeightRatio()
        {
            // TWR = Ft/ m.g > 1 
            return _engineThrust / (_totalShuttleMass * _localGravitationalAccelaration);
        }

        private double CalculateGravitationalAcceleration(double planetRadius, double planetMass)
        {
            return (_universalGravitationalConstant * planetMass) / Math.Pow(planetRadius, 2);
        }

        private void SetUniversalGravitationalConstant()
        {
            _universalGravitationalConstant = 6.6726 * Math.Pow(10, -11);
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

        public double Twr()
        {
            return Math.Round(CalculateThrustToWeightRatio(), 2);
        }

    }
}