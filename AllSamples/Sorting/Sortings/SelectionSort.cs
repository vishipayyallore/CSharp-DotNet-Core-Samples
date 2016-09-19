using System.Linq;
using static System.Console;

namespace Sortings
{
    public class SelectionSort
    {
        public static void Run()
        {
            var arrayData = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            for (var iCtr = 0; iCtr < arrayData.Length - 1; iCtr++)
            {
                var itemIndex = iCtr;
                for (var jCtr = iCtr; jCtr < arrayData.Length; jCtr++)
                {
                    if (arrayData[jCtr] < arrayData[itemIndex])
                    {
                        itemIndex = jCtr;
                    }
                }
                var temp = arrayData[iCtr];
                arrayData[iCtr] = arrayData[itemIndex];
                arrayData[itemIndex] = temp;
                WriteLine($"Pass {iCtr + 1}: {string.Join(" ", arrayData)}");
            }
            WriteLine($"Selection Sorted: {string.Join(" ", arrayData)}\n");
        }
    }
}
