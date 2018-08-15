using CSharp7.Demo.Data;
using Functional.Programs.Library;
using System;
using System.Collections.Generic;
using System.Linq;
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

        static void SelectValues(List<int> numbers, Func<int, bool> filterCriteria)
        {
            numbers.Where(filterCriteria)
                    .ToList()
                    .ForEach(WriteLine);
        }

        static void Main(string[] args)
        {
            var numbers = new List<int> { 3, 8, 4, 6, 1, 7, 5, 2, 9, 10 };

            ForegroundColor = ConsoleColor.Yellow;

            WriteLine($"Using Filter Data for generating Even Numbers");
            var filterData = new FilterData();
            filterData.SelectValues(numbers, e => e % 2 == 0)
                .ForEach(WriteLine);

            WriteLine($"Using Filter Data for generating Even Numbers Using OrderBy");
            filterData
                .SelectValues(numbers, e => e % 2 == 0)
                .OrderBy(e => e)
                .ToList()
                .ForEach(WriteLine);

            // Order by Ascending
            WriteLine($"Using Filter Data for SelectValuesWithOrderBy");
            filterData
                .SelectValuesWithOrderBy(numbers, e => e % 2 == 0, e => e)
                .ForEach(WriteLine);

            // Order by Decending
            WriteLine($"Using Filter Data for SelectValuesWithOrderBy");
            filterData
                .SelectValuesWithOrderBy(numbers, e => e % 2 == 0, e => -e)
                .ForEach(WriteLine);

            Person person = new Person("Shiva", 20_000);
            WriteLine("Person Details");
            WriteLine($"Id: {person.Id}");
            WriteLine($"Name: {person.Name}");
            WriteLine($"Age: {person.Age}");
            WriteLine($"Salary: {person.Salary}");

            WriteLine($"Person.ToString() = {person}");

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
