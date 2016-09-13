using System.Linq;
using static System.Console;

namespace TwoDArray
{

    public class Transpose
    {
        #region Methods.
        public static void Run()
        {
            //Transpose Two D Array
            var inputs = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var numberOfRows = inputs[0];
            if (numberOfRows < 0 || numberOfRows > 10)
            {
                return;
            }
            var numberOfColumns = inputs[1];
            if (numberOfColumns < 0 || numberOfColumns > 10)
            {
                return;
            }
            var numbers = new int[numberOfRows][];

            for (var iCtr = 0; iCtr < numberOfRows; iCtr++)
            {
                numbers[iCtr] = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            }

            for (var iCtr = 0; iCtr < numberOfColumns; iCtr++)
            {
                for (var jCtr = 0; jCtr < numberOfRows; jCtr++)
                {
                    Write($"{numbers[jCtr][iCtr]} ");
                }
                WriteLine();
            }
        }
        #endregion
    }

}
