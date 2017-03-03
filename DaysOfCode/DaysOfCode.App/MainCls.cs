using Days.Programs;
using System;
using static System.Console;

namespace DaysOfCode.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.Cyan;

            new Person().Run();
            new ConditionalStatementsV1().Run();
            new ConditionalStatementsV2().Run();
            new Operators().Run();
            new HelloWorld().Run();
            new DataTypes().Run();

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

            WriteLine("\n\nPress any key.");
            ReadKey();
        }
    }
}
