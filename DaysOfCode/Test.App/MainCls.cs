﻿using System;
using static System.Console;

namespace Test.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            var arrayElements = new int[] { 129, 1, 2, 90, 10, 110 };
            var maximumDifference = arrayElements[1] - arrayElements[0];
            for (var iCtr = 0; iCtr < arrayElements.Length; iCtr++)
            {
                for (var jCtr = iCtr + 1; jCtr < arrayElements.Length; jCtr++)
                {
                    if (maximumDifference < Math.Abs(arrayElements[iCtr] - arrayElements[jCtr]))
                    {
                        maximumDifference = Math.Abs(arrayElements[iCtr] - arrayElements[jCtr]);
                    }
                }
            }
            WriteLine($"{maximumDifference}");
            WriteLine("\n\nPress any key.");
            ReadKey();
        }
    }
}
