using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using System.Linq;
using static System.Console;

namespace LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxInArray();

            GeneralPrograms generalPrograms = new GeneralPrograms();
            generalPrograms.DisplayStairCase(10);

            // Stair Case Program
            var number1 = 4;
            for (var index = 1; index <= number1; index++)
            {
                WriteLine(string.Concat(Enumerable.Repeat("#", index)).PadLeft(number1));
            }


            IMonthNames monthNames = new MonthNames();

            for (var counter = 1; counter <= 10; counter++)
            {
                monthNames.DisplayMonthNames();
            }

            //------------------------------------------------------------------------------------------
            var arrayItems = new int[] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0 };

            var left = 0;
            var right = arrayItems.Length - 1;
            for (var index = 0; index < arrayItems.Length; index++)
            {
                if (arrayItems[left] > arrayItems[right])
                {
                    var temp = arrayItems[left];
                    arrayItems[left] = arrayItems[right];
                    arrayItems[right] = temp;
                    left++;
                    right--;
                }
            }

            ISortBinaryArray sortBinaryArray = new SortBinaryArray();
            sortBinaryArray.SortArray(arrayItems);
            //------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------
            IMath math = new Math();

            Write("\n\nEnter a number for finding Factorial: ");

            if (int.TryParse(ReadLine(), out int number))
            {
                var factorial = math.GetFactorial(number);
                WriteLine($"Factorial: {factorial}");
            }
            //------------------------------------------------------------------------------------------

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void MinMaxInArray()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int min = 0, max = 0;

            for (int index = 0; index < array1.Length; index++)
            {
                var current = array1.Sum() - array1[index];

                if (index == 0)
                {
                    min = max = current;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    else if (current <= min)
                    {
                        min = current;
                    }
                }
                WriteLine(array1.Sum() - array1[index]);
            }
            WriteLine($"{min} {max}");
        }
    }

}


//static Int64 GetSum(int[] array1)
//{
//    Int64 sum = 0;
//    for (var index = 0; index < array1.Length; index++)
//    {
//        sum += array1[index];
//    }

//    return sum;
//}

//static void miniMaxSum(int[] array1)
//{
//    Int64 sum = GetSum(array1);
//    Int64 min = sum, max = 0;

//    for (int index = 0; index < array1.Length; index++)
//    {
//        Int64 current = sum - array1[index];

//        if (current > max)
//        {
//            max = current;
//        }
//        if (current < min)
//        {
//            min = current;
//        }
//    }
//    Console.WriteLine($"{min} {max}");
//}