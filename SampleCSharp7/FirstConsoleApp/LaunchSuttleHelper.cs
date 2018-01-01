using System;
using ClassesAndGenerics;
using static System.Console;

namespace FirstConsoleApp
{
    public class LaunchSuttleHelper
    {

        public void PerformLaunchShuttle()
        {
            double thrust = 220; // kN 
            double shuttleMass = 16.12; // t 
            double gravitationalAccelerationEarth = 9.81;
            double earthMass = 5.9742 * Math.Pow( 10, 24);
            double earthRadius = 6378100;
            double thrustToWeightRatio;

            var nasaShuttle1 = new LaunchShuttle(thrust, shuttleMass, gravitationalAccelerationEarth);
            thrustToWeightRatio = nasaShuttle1.Twr();
            WriteLine(thrustToWeightRatio);

            nasaShuttle1 = new LaunchShuttle(thrust, shuttleMass, Planet.Earth);
            thrustToWeightRatio = nasaShuttle1.Twr();
            WriteLine(thrustToWeightRatio);

            nasaShuttle1 = new LaunchShuttle(thrust, shuttleMass, earthMass, earthRadius);
            thrustToWeightRatio = nasaShuttle1.Twr();
            WriteLine(thrustToWeightRatio);
        }

    }
}