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


            GeneralPrograms generalPrograms = new GeneralPrograms();
            generalPrograms.DisplayStairCase(10);

            // Stair Case Program
            var number1 = 4;
            for(var index=1; index <= number1; index++)
            {
                WriteLine(string.Concat(Enumerable.Repeat("#", index)).PadLeft(number1));
            }
            

            IMonthNames monthNames = new MonthNames();

            for(var counter=1; counter <= 10; counter++)
            {
                monthNames.DisplayMonthNames();
            }

            //------------------------------------------------------------------------------------------
            var arrayItems = new int[] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0 };

            var left = 0;
            var right = arrayItems.Length - 1;
            for(var index=0; index<arrayItems.Length; index++)
            {
                if(arrayItems[left] > arrayItems[right])
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

    }

}
