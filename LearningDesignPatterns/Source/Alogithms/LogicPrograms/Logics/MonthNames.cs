using LogicPrograms.Interfaces;
using System;

using static System.Console;

namespace LogicPrograms.Logics
{

    public class MonthNames : IMonthNames
    {

        public void DisplayMonthNames()
        {
            for (var month = 1; month <= 12; month++)
            {
                WriteLine($"{month}. {new DateTime(DateTime.Now.Year, month, 1).ToString("MMMM")}");
            }
        }

    }

}
