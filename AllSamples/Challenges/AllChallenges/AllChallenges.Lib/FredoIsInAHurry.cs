using static System.Console;

namespace AllChallenges.Lib
{
    public class FredoIsInAHurry
    {
        public static void Run()
        {
            var numberOfRepeats = int.Parse(ReadLine().Trim());
            while (numberOfRepeats > 0)
            {
                var walkingTime = 0;
                var iCtr = 1;
                var numberOfFloors = int.Parse(ReadLine().Trim());
                if (numberOfFloors == 1)
                {
                    walkingTime = 1;
                    goto Display_Output;
                }
                while (numberOfFloors >= 0)
                {
                    if (numberOfFloors > walkingTime)
                    {
                        walkingTime += iCtr++;
                    }
                    else
                    {
                        walkingTime = (walkingTime == numberOfFloors) ? numberOfFloors * 2 : (numberOfFloors + 1) * 2;
                        break;
                    }
                    numberOfFloors--;
                }
            Display_Output:
                WriteLine($"{walkingTime}");
                numberOfRepeats--;
            }
        }
    }
}
