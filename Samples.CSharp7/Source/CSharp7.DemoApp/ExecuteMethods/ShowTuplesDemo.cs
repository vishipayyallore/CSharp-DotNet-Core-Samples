using System;
using TupulesDemo.Library;
using static System.Console;

namespace CSharp7.DemoApp.ExecuteMethods
{
    public class ShowTuplesDemo
    {

        private readonly ExecuteMethodsHelper _executeMethodsHelper;

        public ShowTuplesDemo()
        {
            _executeMethodsHelper = new ExecuteMethodsHelper();
        }

        public ShowTuplesDemo ExecuteNamedUnnamedTuplesDemo()
        {
            var tuplesDemo = new BasicTuplesDemo();

            _executeMethodsHelper.ShowHeader("ShowTuplesDemo::Execute Named Unnamed Tuples Demo");

            var namedPerson = tuplesDemo.GetNamedPerson();
            WriteLine($"ShowTuplesDemo::GetNamedPerson => Named Person: {namedPerson.Id} {namedPerson.Name} {namedPerson.Age}");

            // Deconstruct the Tuple
            var (Id, Name, Age) = tuplesDemo.GetNamedPerson();
            WriteLine($"ShowTuplesDemo::GetNamedPerson => Named Person: {Id} {Name} {Age}");

            var unnamedPerson = tuplesDemo.GetUnnamedPerson();
            WriteLine($"ShowTuplesDemo::GetUnnamedPerson => Unnamed Person: {unnamedPerson.Item1} {unnamedPerson.Item2} {unnamedPerson.Item3}");

            (Id, Name, Age) = tuplesDemo.GetUnnamedPerson();
            WriteLine($"ShowTuplesDemo::GetUnnamedPerson => Named Person: {Id} {Name} {Age}");

            return this;
        }


        public ShowTuplesDemo ShowSimpleTuplesDemo()
        {
            _executeMethodsHelper.ShowHeader("ShowTuplesDemo::Show Simple Tuples Demo");

            (Guid, string, int) unnamedPerson = (Guid.NewGuid(), "Shiva Sai", 25);
            WriteLine($"Unnamed Person: {unnamedPerson.Item1} {unnamedPerson.Item2} {unnamedPerson.Item3}");

            (Guid Id, string Name, int Age) namedPerson = (Id: Guid.NewGuid(), Name: "Shiva Sai", Age: 25);
            WriteLine($"Named Person: {namedPerson.Id} {namedPerson.Name} {namedPerson.Age}");

            return this;
        }

        public ShowTuplesDemo ExecuteNamedUnnamedTuplesDemoWithDiscards()
        {
            var tuplesDemo = new BasicTuplesDemo();

            _executeMethodsHelper.ShowHeader("ShowTuplesDemo::Execute Named Unnamed Tuples Demo With Discards");

            var (Id, Name, _) = tuplesDemo.GetNamedPerson();
            WriteLine($"ShowTuplesDemo::ExecuteNamedUnnamedTuplesDemoWithDiscards => Named Person: {Id} {Name} No Age");

            (Id, Name, _) = tuplesDemo.GetUnnamedPerson();
            WriteLine($"ShowTuplesDemo::ExecuteNamedUnnamedTuplesDemoWithDiscards => Named Person: {Id} {Name}  No Age");

            return this;
        }

    }

}
