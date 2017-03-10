using Days.Programs;
using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace DaysOfCode.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.Cyan;

            var iterations = int.Parse(ReadLine().Trim());
            while(iterations-- > 0)
            {
                var word = ReadLine().Trim();
                var oddData = new StringBuilder(" ");
                for (var iCtr = 0; iCtr < word.Length; iCtr += 2)
                {
                    Write($"{word[iCtr]}");
                    if((iCtr+1) < word.Length)
                    {
                        oddData.Append(word[iCtr + 1]);
                    }
                }
                WriteLine($"{oddData.ToString()}");
            }

            new LoopsDemo().Run();
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
