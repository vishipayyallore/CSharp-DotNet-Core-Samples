using System;
using System.Linq;
using System.Runtime.CompilerServices;
using InputOutput.Lib;
using static System.Console;

namespace InputOutput.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            
            

            Factorial.Run();

            RoyAndProfilePicture.Run();

            CountDivisors.Run();

            FindProduct.Run();

            PalindromicString.Run();

            ToggleString.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
