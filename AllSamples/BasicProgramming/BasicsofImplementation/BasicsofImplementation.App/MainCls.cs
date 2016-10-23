using System;
using System.Collections.Generic;
using System.Linq;
using BasicsofImplementation.Lib;
using static System.Console;

namespace BasicsofImplementation.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            ulong sum = 0;
            ulong calculatedSum = 0;
            var numberOfRepeatations = int.Parse(ReadLine().Trim());
            while (numberOfRepeatations-- > 0)
            {
                sum = 0;
                var numberOfRows = int.Parse(ReadLine().Trim());
                for ( ; numberOfRows>0; numberOfRows--)
                {
                    var arrayElements = ReadLine().Trim().Split(' ').Select(ulong.Parse).ToArray();
                    for ( var iCtr= arrayElements[0]; iCtr>0; iCtr--)
                    {
                        sum += arrayElements[1];
                    }
                }

                if (sum < 10)
                {
                    goto Display_Output;
                }

                
                while (sum > 9)
                {
                    calculatedSum = sum;
                    sum = 0;
                    while (calculatedSum > 0)
                    {
                        sum += calculatedSum % 10;
                        calculatedSum /= 10;
                    }
                }

                Display_Output:
                WriteLine($"{sum}");
            }
            

            Printhackerearth.Run();

            LittleJhoolPsychicPowers.Run();

            TheGreatKian.Run();

            CountDigits.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
