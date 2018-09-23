using System;
using TupulesDemo.Library;
using static System.Console;

namespace CSharp7.DemoApp.ExecuteMethods
{
    public class ShowTuplesDemo
    {
        public ShowTuplesDemo ExecuteNamedUnnamedTuplesDemo()
        {
            var tuplesDemo = new BasicTuplesDemo();

            ShowHeader("ShowTuplesDemo::Execute Named Unnamed Tuples Demo");

            // Deconstruct the Tuple
            var (Id, Name, Age) = tuplesDemo.GetNamedPerson();
            WriteLine($"ShowTuplesDemo::GetNamedPerson => Named Person: {Id} {Name} {Age}");

            var unnamedPerson = tuplesDemo.GetUnnamedPerson();
            WriteLine($"ShowTuplesDemo::GetUnnamedPerson => Unnamed Person: {unnamedPerson.Item1} {unnamedPerson.Item2} {unnamedPerson.Item3}");

            return this;
        }


        public ShowTuplesDemo ShowSimpleTuplesDemo()
        {
            ShowHeader("ShowTuplesDemo::Show Simple Tuples Demo");

            (Guid, string, int) unnamedPerson = (Guid.NewGuid(), "Shiva Sai", 25);
            WriteLine($"Unnamed Person: {unnamedPerson.Item1} {unnamedPerson.Item2} {unnamedPerson.Item3}");

            (Guid Id, string Name, int Age) namedPerson = (Id: Guid.NewGuid(), Name: "Shiva Sai", Age: 25);
            WriteLine($"Named Person: {namedPerson.Id} {namedPerson.Name} {namedPerson.Age}");

            return this;
        }

        private void ShowHeader(string title)
        {
            WriteLine($"***** {title} *****");
        }

    }

}
