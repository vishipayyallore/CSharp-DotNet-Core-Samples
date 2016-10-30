using System.Linq;
using ArraysNStrings.Lib;
using static System.ConsoleColor;
using static System.Console;

namespace ArraysNStrings.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = Cyan;

            Palindrome.Run();

            Welcome.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
