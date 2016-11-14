using System;
using System.Collections.Generic;
using System.Linq;
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
