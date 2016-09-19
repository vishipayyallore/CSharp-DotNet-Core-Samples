using System;
using System.Linq;
using static System.Console;

namespace Sortings
{

    /*
       Step 1 − If it is the first element, it is already sorted. return 1;
       Step 2 − Pick next element
       Step 3 − Compare with all elements in the sorted sub-list
       Step 4 − Shift all the elements in the sorted sub-list that is greater than the value to be sorted
       Step 5 − Insert the value
       Step 6 − Repeat until list is sorted
   */
    public class InsertionSort
    {
        public static void Run()
        {
            //Selection Sort. {76 45 92 67 89 12 99 | 7 4 5 2 | 34 4 83 9 6 45}
            var arrayData = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            for (var iCtr = 1; iCtr < arrayData.Length; iCtr++)
            {
                var jCtr = iCtr;
                while (jCtr > 0)
                {
                    if (arrayData[jCtr - 1] > arrayData[jCtr])
                    {
                        var temp = arrayData[jCtr];
                        arrayData[jCtr] = arrayData[jCtr - 1];
                        arrayData[jCtr - 1] = temp;
                    }
                    jCtr--;
                }
                WriteLine($"Pass {iCtr}: {string.Join(" ", arrayData)}");
            }
            WriteLine($"\nInsertion Sorted: {string.Join(" ", arrayData)}\n");
        }
    }
}
