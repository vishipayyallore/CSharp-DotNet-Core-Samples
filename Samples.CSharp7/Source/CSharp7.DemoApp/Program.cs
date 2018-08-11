using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Console;

namespace CSharp7.DemoApp
{
    class Program
    {

        static void SelectNumbers(List<int> numbers, Func<int, bool> filterCriteria)
        {
            foreach(var number in numbers)
            {
                var output = filterCriteria(number);
                WriteLine($"{number} = {output} ");
            }

            numbers.ForEach(number =>
            {
                var output = filterCriteria(number);
                WriteLine($"2. {number} = {output} ");
            });
        }

        static void SelectValues(List<int> numbers, Func<int, bool> predicate)
        {
            numbers.Where(predicate)
                    .ToList()
                    .ForEach(WriteLine);
        }

        static void Main(string[] args)
        {
            var numbers = new List<int> { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8, 0 };

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Hello World!");

            SelectNumbers(numbers, x => (x%2 == 0));

            WriteLine($"Selecting number which are divided by 2");
            SelectValues(numbers, e => e % 2 == 0);

            WriteLine($"Selecting number which are divided by 3");
            SelectValues(numbers, e => e % 3 == 0);

            WriteLine("\n\nPress any key ...");
            Read();
        }
    }
}
