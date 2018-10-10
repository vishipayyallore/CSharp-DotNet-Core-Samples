using CSharp7.Demo.Data;
using CSharp7.DemoApp.ExecuteMethods;
using CSharp7.Logic.Programs;
using Functional.Programs.Library;
using GenericsDemo.Library;
using LambdaDemo.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static System.Console;

namespace CSharp7.DemoApp
{

    class Program
    {

        static void SelectNumbers(List<int> numbers, Func<int, bool> filterCriteria)
        {
            foreach (var number in numbers)
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

        static T TryParse<T>(T inputType, string value)
        {
            var dataType = inputType.GetType();
            var tryParseMethod = dataType.GetMember("TryParse");
            object[] parametersArray = new object[] { value, null };
            var output = ((MethodInfo)tryParseMethod[0]).Invoke(dataType, parametersArray);
            if ((bool)output)
            {
                WriteLine($"Parsed Number: {parametersArray[1]}");
            }

            return (T)parametersArray[1];
        }

        static void TryParseV2<T>(ref T inputType, string value)
        {
            var dataType = inputType.GetType();
            var tryParseMethod = dataType.GetMember("TryParse");
            object[] parametersArray = new object[] { value, null };
            var output = ((MethodInfo)tryParseMethod[0]).Invoke(dataType, parametersArray);
            inputType = ((bool)output) ? (T)parametersArray[1] : inputType;
        }

        static void PrintActionGeneric<T>(T data)
        {
            WriteLine(data);
        }

        static List<int> SelectArrayValues(int[] numbers, Func<int, bool> filterCriteria)
        {
            return numbers.Where(filterCriteria)
                    .ToList();
        }

        static void Main(string[] args)
        {
            var numbers = new List<int> { 3, 8, 4, 6, 1, 7, 5, 2, 9, 10 };

            ForegroundColor = ConsoleColor.Yellow;

            WriteLine($"Sample Sort Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of Values: ");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            new SampleSort()
                .Execute(arrayValues);

            new PlusMinus()
                .Execute();

            var numberOfItems = int.Parse(ReadLine().Trim());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var values = SelectArrayValues(arrayValues, e => e > 0);
            WriteLine(string.Format("{0:F6}", (values.Count / (numberOfItems * 1.0))));

            values = SelectArrayValues(arrayValues, e => e < 0);
            WriteLine(string.Format("{0:F6}", (values.Count / (numberOfItems * 1.0))));

            values = SelectArrayValues(arrayValues, e => e == 0);
            WriteLine(string.Format("{0:F6}", (values.Count / (numberOfItems * 1.0))));

            // To be continued ....

            new ShowTuplesDemo()
                .ShowSimpleTuplesDemo()
                .ExecuteNamedUnnamedTuplesDemo()
                .ExecuteNamedUnnamedTuplesDemoWithDiscards();

            // Local functions
            void printAction(int data)
            {
                WriteLine("Multiplying by 2");
                data *= 2;
                WriteLine(data);
            }

            void printAction1(string data) => WriteLine(data);

            new ShowLambdaDemos()
                .ShowSimpleLambdaDemo();

            new ShowFilteredDataDemo()
                .ShowSimpleFilteredDataDemo();

            // Converted into Local Function
            List<int> doubleNumbers(List<int> nums)
            {
                List<int> doubles = new List<int>();
                nums.ForEach(number => { doubles.Add(number * 2); });
                return doubles;
            }

            doubleNumbers(numbers).ForEach(value => WriteLine(value));

            FilterData filterDataObject = new FilterData();
            filterDataObject.GetNumbersDouble(doubleNumbers, numbers).ForEach(value => WriteLine(value));

            new BasicLambdaDemo()
                .PrintData(PrintActionGeneric, "Shiva Sai")
                .PrintData(PrintActionGeneric, 125)
                .PrintData(PrintActionGeneric, 123.45f)
                .PrintData(PrintActionGeneric, 123.45M)
                .PrintData(PrintActionGeneric, 'A')
                .PrintData(PrintActionGeneric, DateTime.Now);

            printAction(10);

            var parsedData = TryParse<int>(numbers[0], "125");
            WriteLine($"Parsed in Generic Method: {parsedData}");

            int getNumber = 0;
            TryParseV2(ref getNumber, "2468");
            WriteLine($"Parsed in Generic Method: {getNumber}");

            DateTime dateTime = DateTime.Now;
            TryParseV2(ref dateTime, "01-Aug-2016");
            WriteLine($"DateTime Parsed in Generic Method: {dateTime}");

            bool results = false;
            TryParseV2(ref results, "true");
            WriteLine($"Bool Parsed in Generic Method: {results}");

            var genericTryParse = new GenericTryParse();
            getNumber = 0;
            genericTryParse.TryParse(ref getNumber, "2468");
            WriteLine($"GenericTryParse::TryParse Int: {getNumber}");

            dateTime = DateTime.Now;
            genericTryParse.TryParse(ref dateTime, "01-Aug-2016");
            WriteLine($"GenericTryParse::TryParse DateTime: {dateTime}");

            results = false;
            genericTryParse.TryParse(ref results, "true");
            WriteLine($"GenericTryParse::TryParse Bool: {results}");

            float salary = 0.0f;
            genericTryParse.TryParse(ref salary, "125.67");
            WriteLine($"GenericTryParse::TryParse Float: {salary}");

            List<int> generalVariable = new List<int>()
            {
                45
            };

            var dataType = generalVariable[0].GetType();
            var tryParseMethod = dataType.GetMember("TryParse");
            object[] parametersArray = new object[] { "12", null };
            var output = ((MethodInfo)tryParseMethod[0]).Invoke(dataType, parametersArray);
            if ((bool)output)
            {
                WriteLine($"Parsed Number: {parametersArray[1]}");
            }


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

            Person person = new Person("Shiva", 20_000)
            {
                // Age = 25 // Illegal as it is readonly
            };
            WriteLine("Person Details");
            WriteLine($"Id: {person.Id}");
            WriteLine($"Name: {person.Name}");
            WriteLine($"Age: {person.Age}");
            WriteLine($"Salary: {person.Salary}");

            WriteLine($"Person.ToString() = {person}");

            // Tuple is Deconstructed
            var (Id, Name) = person.PersonInformation;
            WriteLine($"From Tuple = {Id} {Name}");

            person.Name = null;
            WriteLine($"Name [null coalescing]: {person.Name ?? "No Name"}");

            person = null;
            WriteLine($"Name [Null-Condition and null coalescing]: {person?.Name ?? "No Name"}");

            SelectNumbers(numbers, x => (x % 2 == 0));

            WriteLine($"Selecting number which are divided by 2");
            SelectValues(numbers, e => e % 2 == 0);

            WriteLine($"Selecting number which are divided by 3");
            SelectValues(numbers, e => e % 3 == 0);

            WriteLine("\n\nPress any key ...");
            Read();
        }
    }
}
