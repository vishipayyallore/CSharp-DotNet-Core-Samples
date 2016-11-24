using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.ConsoleColor;

namespace ByteCode1._0.App
{

    public class Program
    {
        /*
         * 10
pe8150 
pe8152
pe8150
pe8151
pe8150
pe8152
pe815
pe815
pe8150
pe8153
         */
        public static void Main(string[] args)
        {
            ForegroundColor = Cyan;

            var numberOfRepeats = int.Parse(ReadLine().Trim());
            while (numberOfRepeats > 0)
            {
                var walkingTime = 0;
                var iCtr = 1;
                var numberOfFloors = int.Parse(ReadLine().Trim());
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
                WriteLine($"{walkingTime}");
                numberOfRepeats--;
            }
            
            var numberOfRepeatations = int.Parse(ReadLine().Trim());
            while (numberOfRepeatations-- > 0)
            {
                ulong sum = 0;
                byte flag = 0;
                var numberOfRows = int.Parse(ReadLine().Trim());
                for (; numberOfRows > 0; numberOfRows--)
                {
                    var arrayElements = ReadLine().Trim().Split(' ').Select(ulong.Parse).ToArray();
                    if (arrayElements[0] == 0 || arrayElements[1] == 0) continue;
                    sum += ((arrayElements[0] % 9) * (arrayElements[1] % 9)) % 9;
                    sum = sum%9;
                    flag = 1;
                }

                if (sum == 0 && flag == 1)
                {
                    sum = 9;
                }
                WriteLine($"{sum}");
            }

            var numberOfIterations = int.Parse(ReadLine().Trim());
            var loginIds = new List<string>();
            for ( ; numberOfIterations>0; numberOfIterations--)
            {
                var loginId = ReadLine().Trim();
                if (!loginIds.Contains(loginId))
                {
                    loginIds.Add(loginId);
                }
                else
                {
                    var lastChar = loginId[loginId.Length - 1];
                    var startValue = 0;
                    int.TryParse(string.Format("{0}", lastChar), out startValue);
                    for ( ; startValue < 100000; startValue++)
                    {
                        if (loginIds.Contains(string.Format("{0}{1}", loginId, startValue)))
                        {
                            continue;
                        }
                        loginIds.Add(string.Format("{0}{1}", loginId, startValue));
                        break;
                    }
                }
            }
            foreach (var loginId in loginIds)
            {
                WriteLine($"{loginId}");
            }

            Console.WriteLine("Press ESC to stop");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
