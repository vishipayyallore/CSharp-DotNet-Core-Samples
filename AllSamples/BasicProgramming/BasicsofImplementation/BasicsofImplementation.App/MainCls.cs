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

            TheGreatKian.Run();

            CountDigits.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
