using Days.CoreLibrary;
using System.Linq;
using static System.Console;

namespace Days.Programs
{

    public class HourGlass2DArray : IProgram
    {
        static int[][] arrayData = new int[6][];

        private static int GetHourGlassValue(int startRow, int startColumn, int itemsToCover)
        {
            var output = 0;
            for (var iCtr = startRow; iCtr <= (startRow + itemsToCover); iCtr += 2)
            {
                for (var jCtr = startColumn; jCtr <= (startColumn + itemsToCover); jCtr++)
                {
                    output += arrayData[iCtr][jCtr];
                }
            }
            output += arrayData[startRow + 1][startColumn + 1];
            return output;
        }

        public void Run()
        {
            for(var iCtr=0; iCtr<6; iCtr++)
            {
                arrayData[iCtr] = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            }

            var output = int.MinValue;
            var returnValue =0;
            for (var iCtr = 0; iCtr <= 3; iCtr++)
            {
                for (var jCtr = 0; jCtr <= 3; jCtr++)
                {
                    returnValue = GetHourGlassValue(iCtr, jCtr, 2);
                    output = (output < returnValue) ? returnValue : output;
                }
            }

            WriteLine($"{output}");
        }
    }

}
