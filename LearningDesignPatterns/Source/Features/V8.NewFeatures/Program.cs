using System;
using V8.NewFeatures.Models;
using static System.Console;

namespace V8.NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Id = Guid.NewGuid(), Name = "Shiva Sai" };
            WriteLine(person);

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
