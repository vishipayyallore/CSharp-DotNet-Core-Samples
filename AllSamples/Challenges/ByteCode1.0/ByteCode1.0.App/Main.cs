using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.ConsoleColor;

namespace ByteCode1._0.App
{

    public class Program
    {

        public static void Main(string[] args)
        {
            ForegroundColor = Cyan;

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
                    for (var iCtr = 0; iCtr < 100000; iCtr++)
                    {
                        if (loginIds.Contains(string.Format("{0}{1}", loginId, iCtr)))
                        {
                            continue;
                        }
                        loginIds.Add(string.Format("{0}{1}", loginId, iCtr));
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
