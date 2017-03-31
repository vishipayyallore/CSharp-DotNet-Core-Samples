using System;
using static System.Console;

namespace Test.App
{

    public class MainCls
    {

        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;

            WriteLine("\n\nPress any key.");
            ReadKey();
        }
    }
}
