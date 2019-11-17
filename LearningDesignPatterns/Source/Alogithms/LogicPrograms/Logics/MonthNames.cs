using LogicPrograms.Interfaces;
using System;
using System.Diagnostics;
using static System.Console;

namespace LogicPrograms.Logics
{

    public class MonthNames : IMonthNames
    {

        public void DisplayMonthNames()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (var month = 1; month <= 12; month++)
            {
                WriteLine($"{month}. {new DateTime(DateTime.Now.Year, month, 1).ToString("MMMM")}");
            }

            WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} Milli-Seconds");
            stopwatch.Stop();
        }

    }

}
