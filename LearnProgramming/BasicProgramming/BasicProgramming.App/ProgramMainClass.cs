using System;
using System.Reflection;
using static System.Console;

namespace BasicProgramming.App
{
    class ProgramMainClass
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;

            var assemblyNames = new string[] { "Programs.Library" };
            const string METHODNAME = "Run";

            foreach (var assemblyName in assemblyNames)
            {
                RunPrograms(assemblyName, METHODNAME);
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void RunPrograms(string assemblyName, string methodName)
        {
            var programsAssembly = Assembly.Load(new AssemblyName(assemblyName));
            foreach (var currentClass in programsAssembly.GetTypes())
            {
                var currentMethod = currentClass.GetMethod(methodName);
                WriteLine($"{currentClass.Name} ....");
                currentMethod.Invoke(Activator.CreateInstance(currentClass), null);
            }
        }
    }
}