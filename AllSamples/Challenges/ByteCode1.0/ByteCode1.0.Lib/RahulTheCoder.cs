using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;

namespace ByteCode1._0.Lib
{
    public class Class1
    {
        private const int TimeLimitSeconds = 10;
        private static readonly StringBuilder InputContent = new StringBuilder();
        private static readonly Dictionary<char, int> DataCounts = new Dictionary<char, int>
            {
                {'A', 0 },{'B', 0 },{'C', 0 },{'D', 0 },{'E', 0 },{'F', 0 },{'G', 0 },{'H', 0 },{'I', 0 },
                {'J', 0 },{'K', 0 },{'L', 0 },{'M', 0 },{'N', 0 },{'O', 0 },{'P', 0 },{'Q', 0 },{'R', 0 },
                {'S', 0 },{'T', 0 },{'U', 0 },{'V', 0 },{'W', 0 },{'X', 0 },{'Y', 0 },{'Z', 0 },
            };

        private static void MainLoop()
        {
            var elapsedMilliseconds = 0;
            const int totalMilliseconds = TimeLimitSeconds * 1000;
            const int interval = 100;

            while (elapsedMilliseconds < totalMilliseconds)
            {
                elapsedMilliseconds += interval;
                HandleInput();
            }
        }

        private static void HandleInput()
        {
            if (!Console.KeyAvailable) return;
            var keyInfo = ReadLine();
            InputContent.Append(keyInfo);
        }

        public static void Run()
        {
            var inputBuffer = new byte[4096];
            var inputStream = Console.OpenStandardInput();
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            MainLoop();

            foreach (var currentChar in InputContent.ToString().Trim().ToUpperInvariant().Where(currentChar => DataCounts.ContainsKey(currentChar)))
            {
                DataCounts[currentChar] += 1;
            }

            foreach (var keyValuePair in DataCounts.Where(k => k.Value > 0))
            {
                WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
            }
        }
    }
}
