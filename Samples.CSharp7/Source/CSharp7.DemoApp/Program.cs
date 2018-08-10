using System;
using static System.Console;

namespace CSharp7.DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Hello World!");

            WriteLine("\n\nPress any key ...");
            Read();
        }
    }
}
