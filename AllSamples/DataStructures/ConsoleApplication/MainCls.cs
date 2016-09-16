using System;
using System.Linq;
using SingleDArray;
using static System.Console;
using TwoDArray;

namespace DataStructureConsoleApp
{

    public class MainCls
    {

        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            //Speed of Cars Count
            CarsSpeed.Run();

            //MonksLoveForFood
            MonksLoveForFood.Run1();

            //Two D Array
            Transpose.Run();

            //Print SD Array in Reverse
            var numberOfRepetations = int.Parse(ReadLine().Trim());
            for ( ; numberOfRepetations>0; numberOfRepetations--)
            {
                var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                PrintReverse.Run(arrayElements);
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
