using System;
using ClassesAndGenerics;
using Common.Enums;
using static System.Console;

namespace FirstConsoleApp
{
    public class LaunchSuttleHelper
    {

        public void PerformLaunchShuttle()
        {
            double thrust = 220; // kN 
            var shuttleMass = 16.12; // t 
            var gravitationalAccelerationEarth = 9.81;
            var earthMass = 5.9742 * Math.Pow( 10, 24);
            double earthRadius = 6378100;

            var nasaShuttle1 = new LaunchShuttle(thrust, shuttleMass, gravitationalAccelerationEarth);
            WriteLine(nasaShuttle1.Twr());

            nasaShuttle1 = new LaunchShuttle(thrust, shuttleMass, Planet.Earth);
            WriteLine(nasaShuttle1.Twr());

            nasaShuttle1 = new LaunchShuttle(thrust, shuttleMass, earthMass, earthRadius);
            WriteLine(nasaShuttle1.Twr());
        }

    }
}