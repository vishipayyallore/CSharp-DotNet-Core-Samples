using static System.Console;

namespace InputOutput.Lib
{
    public class Factorial
    {
        #region Methods
        public static void Run()
        {
            var number = int.Parse(ReadLine().Trim());
            var factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            WriteLine(factorial);
        }
        #endregion

    }
}
