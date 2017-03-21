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

            var programsAssembly = Assembly.Load(new AssemblyName("Basic.Programs"));
            foreach (var currentClass in programsAssembly.GetTypes())
            {
                var currentMethod = currentClass.GetMethod("Run");
                WriteLine($"{currentClass.Name} ....");
                currentMethod.Invoke(Activator.CreateInstance(currentClass), null);
            }

            programsAssembly = Assembly.Load(new AssemblyName("Days.Programs"));
            foreach(var currentClass in programsAssembly.GetTypes())
            {
                var currentMethod = currentClass.GetMethod("Run");
                WriteLine($"{currentClass.Name} ....");
                currentMethod.Invoke(Activator.CreateInstance(currentClass), null);
            }
            
            WriteLine("\n\nPress any key.");
            ReadKey();
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

