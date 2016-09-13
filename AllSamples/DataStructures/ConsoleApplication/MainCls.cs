using System;
using System.Linq;
using SingleDArray;

namespace DataStructureConsoleApp
{

    public class MainCls
    {

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Print SD Array in Reverse
            var numberOfRepetations = int.Parse(Console.ReadLine().Trim());
            for ( ; numberOfRepetations>0; numberOfRepetations--)
            {
                var arrayElements = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                PrintReverse.Run(arrayElements);
            }

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
