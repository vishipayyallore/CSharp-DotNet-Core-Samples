using static System.Console;

namespace InputOutput.Lib
{
    public class LifeTheUniverseAndEverything
    {
        #region Methods
        public static void Run()
        {
            do
            {
                var number = int.Parse(ReadLine().Trim());
                if (number == 42) { break; }
                WriteLine(number);
            } while (true);
        }
        #endregion
    }
}
