using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using static System.ConsoleColor;

namespace ByteCode1._0.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ForegroundColor = Cyan;

            var dataCounts = new Dictionary<char, int>
            {
                {'A', 0 },{'B', 0 },{'C', 0 },{'D', 0 },{'E', 0 },{'F', 0 },{'G', 0 },{'H', 0 },{'I', 0 },
                {'J', 0 },{'K', 0 },{'L', 0 },{'M', 0 },{'N', 0 },{'O', 0 },{'P', 0 },{'Q', 0 },{'R', 0 },
                {'S', 0 },{'T', 0 },{'U', 0 },{'V', 0 },{'W', 0 },{'X', 0 },{'Y', 0 },{'Z', 0 },
            };

            byte[] inputBuffer = new byte[14096];
            Stream inputStream = Console.OpenStandardInput();
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            var data = ReadLine().Trim().ToUpperInvariant();
            foreach (var currentChar in data.Where(currentChar => dataCounts.ContainsKey(currentChar)))
            {
                dataCounts[currentChar] += 1;
            }

            foreach (var keyValuePair in dataCounts.Where(k => k.Value > 0))
            {
                WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
