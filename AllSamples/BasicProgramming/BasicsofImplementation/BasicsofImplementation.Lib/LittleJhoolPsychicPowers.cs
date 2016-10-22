using System.Linq;
using static System.Console;

namespace BasicsofImplementation.Lib
{
    public class LittleJhoolPsychicPowers
    {
        #region Methods.

        public static void Run()
        {
            var data = ReadLine().Trim();
            var onesData = data.Replace('0', ' ').Split(' ').Select(r => r.Length >= 6).ToArray().SingleOrDefault(r => r == true);
            if (onesData)
            {
                goto Sorry_Sorry;
            }
            onesData = data.Replace('1', ' ').Split(' ').Select(r => r.Length >= 6).ToArray().SingleOrDefault(r => r == true);
            if (onesData)
            {
                goto Sorry_Sorry;
            }
            goto Good_luck;

        Good_luck:
            WriteLine("Good luck!");
            goto Exit;

        Sorry_Sorry:
            WriteLine("Sorry, sorry!");

        Exit:
            WriteLine();
        }
        #endregion
    }
}
