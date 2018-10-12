using CSharp7.Logic.Programs;
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

            Write($"Please Enter Array of Values: ");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            new PlusMinus().Execute(numberOfItems, arrayValues);

            return this;
        }


        public ShowLogicDemos SampleSortDemo()
        {
            WriteLine($"Sample Sort Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of Values: ");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            new SampleSort().Execute(arrayValues);

            return this;
        }

    }

}
