using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using static System.Console;

namespace LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------------------------------------------------------------
            var arrayItems = new int[] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0 };

            ISortBinaryArray sortBinaryArray = new SortBinaryArray();
            sortBinaryArray.SortArray(arrayItems);
            //------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------
            IMath math = new Math();

            WriteLine();
            Write("Enter a number for finding Factorial: ");

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
