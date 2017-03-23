using Days.Programs;
using System;
using System.Reflection;
using static System.Console;

namespace DaysOfCode.App
{
    public class MainCls
    {
        
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var assemblyNames = new string[] { "Basic.Programs", "Days.Programs" };
            const string METHODNAME = "Run";

            foreach (var assemblyName in assemblyNames)
            {
                RunPrograms(assemblyName, METHODNAME);
            }

            WriteLine("\n\nPress any key.");
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

//var number = int.Parse(ReadLine().Trim());

//var binaryData = BinaryNumbers.DecimalToBinary(number);
//var binaryValues = binaryData.Split('0');
//var highestNumber = 0;

////Method 1
//highestNumber = binaryValues.OrderByDescending(s => s.Length).First().Length;

////Method 2
//foreach (var binary in binaryValues)
//{
//    var value = binary.Length;
//    if(highestNumber < value)
//    {
//        highestNumber = value;
//    }
//}

//WriteLine($"{highestNumber}");

