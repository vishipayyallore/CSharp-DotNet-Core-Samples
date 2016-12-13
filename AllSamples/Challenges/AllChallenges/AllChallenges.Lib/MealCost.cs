using System;
using static System.Console;

namespace AllChallenges.Lib
{
    public class MealCost
    {
        public static void Run()
        {
            var mealPrice = double.Parse(ReadLine());
            var tipPercent = double.Parse(ReadLine());
            var taxPercent = double.Parse(ReadLine());

            var totalCost = mealPrice + (mealPrice * (tipPercent / 100.0)) + (mealPrice * (taxPercent / 100.0));

            WriteLine($"{Math.Round(totalCost)} ");
        }
    }
}
