using System.Linq;
using static System.Console;
namespace BasicsofImplementation.Lib
{
    public class TheGreatKian
    {
        #region Methods.

        public static void Run()
        {
            var numberOfElements = int.Parse(ReadLine().Trim());
            var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            double value1 = 0, value2 = 0, value3 = 0;

            for (var iCtr = 0; iCtr < numberOfElements; iCtr += 3)
            {
                value1 += arrayElements[iCtr];
                if (iCtr + 1 >= numberOfElements) continue;
                value2 += arrayElements[iCtr + 1];
                if (iCtr + 2 >= numberOfElements) continue;
                value3 += arrayElements[iCtr + 2];
            }
            WriteLine($"{value1} {value2} {value3}");
        }
        #endregion
    }
}
