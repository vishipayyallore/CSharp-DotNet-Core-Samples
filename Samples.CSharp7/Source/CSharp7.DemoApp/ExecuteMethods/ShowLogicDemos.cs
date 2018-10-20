﻿using CSharp7.Logic.Programs;
using System.Linq;
using static System.Console;

namespace CSharp7.DemoApp.ExecuteMethods
{

    public class ShowLogicDemos
    {

        public ShowLogicDemos ShowPlusMinusDemo()
        {
            WriteLine($"\n\nPlus Minus Program!");

            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());

            Write($"Please Enter Array of {numberOfItems} Values [Ex: -1 8 0 3 -8 0]: ");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            new PlusMinus().Execute(numberOfItems, arrayValues);

            return this;
        }

        public ShowLogicDemos SampleSortDemo()
        {
            WriteLine($"Sample Sort Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of {numberOfItems} Values [Ex: -1 2 0 1 -1]: ");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            new SampleSort().Execute(arrayValues);

            return this;
        }

        public ShowLogicDemos ValleyCountDemo()
        {
            WriteLine($"Moutain - Valley Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of {numberOfItems} Values [Ex: UDDDUDUU]: ");
            var valleyPath = ReadLine().Trim();

            new ValleyCount().Execute(valleyPath);

            return this;
        }

    }

}
