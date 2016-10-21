using System;
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

            var numberOfElements = int.Parse(ReadLine().Trim());
            var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            double value1 = 0, value2 = 0, value3 = 0;

            for (var iCtr = 0; iCtr < numberOfElements; iCtr+=3)
            {
                value1 += arrayElements[iCtr];
                if (iCtr + 1 >= numberOfElements) continue;
                value2 += arrayElements[iCtr+1];
                if(iCtr + 2 >= numberOfElements) continue;
                value3 += arrayElements[iCtr+2];
            }
            WriteLine($"{value1} {value2} {value3}");

            CountDigits.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
