using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class War
    {
        public static void Run()
        {
            var numberOfRepeats = int.Parse(ReadLine().Trim());
            while (numberOfRepeats > 0)
            {
                var numberOfSoldiers = int.Parse(ReadLine().Trim());
                var bobsArmy = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var alicesArmy = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var bobsArmyCount = 0;
                var alicesArmyCount = 0;
                for (var iCtr = 0; iCtr < numberOfSoldiers; iCtr++)
                {
                    if (bobsArmy[iCtr] >= bobsArmyCount)
                    {
                        bobsArmyCount = bobsArmy[iCtr];
                    }
                    if (alicesArmy[iCtr] >= alicesArmyCount)
                    {
                        alicesArmyCount = alicesArmy[iCtr];
                    }
                }

                var output = (bobsArmyCount == alicesArmyCount)
                    ? "Tie"
                    : (bobsArmyCount > alicesArmyCount) ? "Bob" : "Alice";
                WriteLine($"{output}");
                numberOfRepeats--;
            }
        }
    }
}
