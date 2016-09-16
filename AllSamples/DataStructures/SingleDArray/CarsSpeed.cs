using System.Linq;
using static System.Console;

namespace SingleDArray
{
    /*
     * 
     */
    public class CarsSpeed
    {
        public static void Run()
        {
            var numberOfRepitations = int.Parse(ReadLine().Trim());
            for (; numberOfRepitations > 0; numberOfRepitations--)
            {
                var numberOfCars = int.Parse(ReadLine().Trim());
                var carSpeeds = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                var count = 1;
                var minimumValue = carSpeeds[0];
                for (var iCtr = 1; iCtr < numberOfCars; iCtr++)
                {
                    if (minimumValue < carSpeeds[iCtr]) continue;
                    count++;
                    minimumValue = carSpeeds[iCtr];
                }
                WriteLine($"{count}");
            }
        }
    }

}
