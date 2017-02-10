using System;
using System.Collections.Generic;
using static System.Console;

namespace DaysOfCode.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var stackData = new Stack<int>();
            var number = int.Parse(ReadLine().Trim());

            while(number > 0)
            {
                stackData.Push(number % 2);
                number /= 2;
            }

            var dat1a = string.Join("", stackData.ToArray());

            foreach(var data in stackData)
            {
                Write($"{data}");
            }

            WriteLine("\n\nPress any key.");
            ReadKey();
        }
    }
}
