using System;
using System.Linq;

namespace Sortings
{
    public class BubbleSort
    {
        //Bubble Sort. {89 76 45 92 67 12 99 | 7 4 5 2 | 4 83 9 6 34 45}
        public static void Run()
        {
            var arrayData = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            for (var iCtr = 0; iCtr < arrayData.Length - 1; iCtr++)
            {
                for (var jCtr = 0; jCtr < arrayData.Length - (iCtr + 1); jCtr++)
                {
                    if (arrayData[jCtr] <= arrayData[jCtr + 1]) continue;
                    var temp = arrayData[jCtr];
                    arrayData[jCtr] = arrayData[jCtr + 1];
                    arrayData[jCtr + 1] = temp;
                }
                Console.WriteLine($"Pass {iCtr + 1}: {string.Join(" ", arrayData)}");
            }
            Console.WriteLine($"\nBubble Sorted: {string.Join(" ", arrayData)}\n");
        }
    }
}
