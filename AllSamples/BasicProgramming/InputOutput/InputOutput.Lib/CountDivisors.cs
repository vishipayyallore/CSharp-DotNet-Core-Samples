using System.Linq;
using static System.Console;

namespace InputOutput.Lib
{
    public class CountDivisors
    {
        #region Methods.
        public static void Run()
        {
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var count = 0;
            for (var iCtr = arrayValues[0]; iCtr <= arrayValues[1]; iCtr++)
            {
                if (iCtr % arrayValues[2] == 0)
                {
                    count++;
                }
            }
            WriteLine(count);
        }
        #endregion
    }
}
