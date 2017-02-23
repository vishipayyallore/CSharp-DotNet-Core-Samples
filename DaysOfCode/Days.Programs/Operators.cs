using Days.CoreLibrary;
using System;
using static System.Console;

namespace Days.Programs
{
    public class Operators : IProgram
    {
        public void Run()
        {
            var mealPrice = double.Parse(ReadLine().Trim());
            var tipPercent = int.Parse(ReadLine().Trim());
            var taxPercent = int.Parse(ReadLine().Trim());

            var totalCost = mealPrice + (mealPrice * (tipPercent / 100.0)) + (mealPrice * (taxPercent / 100.0));
            WriteLine($"The total meal cost is {Math.Round(totalCost)} dollars.");
        }
    }
}
