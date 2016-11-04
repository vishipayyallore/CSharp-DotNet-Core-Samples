using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;

namespace ByteCode1._0.App
{
    public class Program
    {
        /// <summary>
        /// The time limit for the puzzle
        /// </summary>
        const int TIME_LIMIT_SECONDS = 1500;

        /// <summary>
        /// Set this static field to true to quit the game
        /// </summary>
        static bool quit = false;

        static StringBuilder inputContent = new StringBuilder();

        static Dictionary<char, int> dataCounts = new Dictionary<char, int>
            {
                {'A', 0 },{'B', 0 },{'C', 0 },{'D', 0 },{'E', 0 },{'F', 0 },{'G', 0 },{'H', 0 },{'I', 0 },
                {'J', 0 },{'K', 0 },{'L', 0 },{'M', 0 },{'N', 0 },{'O', 0 },{'P', 0 },{'Q', 0 },{'R', 0 },
                {'S', 0 },{'T', 0 },{'U', 0 },{'V', 0 },{'W', 0 },{'X', 0 },{'Y', 0 },{'Z', 0 },
            };

        /// <summary>
        /// The main gameloop
        /// </summary>
        static void MainLoop()
        {
            int elapsedMilliseconds = 0;
            int totalMilliseconds = TIME_LIMIT_SECONDS * 1000;
            const int INTERVAL = 100;

            while (elapsedMilliseconds < totalMilliseconds)
            {
                // Sleep for a short period
                //Thread.Sleep(INTERVAL);
                elapsedMilliseconds += INTERVAL;

                HandleInput();

                //PrintRemainingTime(elapsedMilliseconds, totalMilliseconds);
            }

            //Console.SetCursorPosition(0, 20);
            //Console.WriteLine(Environment.NewLine + Environment.NewLine + "Game over! You found {0} words.");
        }

        /// <summary>
        /// Handle any waiting user keystrokes 
        /// </summary>
        static void HandleInput()
        {
            //Thread.Sleep(50);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                inputContent.Append(keyInfo.KeyChar.ToString().ToUpper());
                //Write(key);
            }
        }

        public static void Main(string[] args)
        {
            ForegroundColor = Cyan;

            var dataCounts = new Dictionary<char, int>
            {
                {'A', 0 },{'B', 0 },{'C', 0 },{'D', 0 },{'E', 0 },{'F', 0 },{'G', 0 },{'H', 0 },{'I', 0 },
                {'J', 0 },{'K', 0 },{'L', 0 },{'M', 0 },{'N', 0 },{'O', 0 },{'P', 0 },{'Q', 0 },{'R', 0 },
                {'S', 0 },{'T', 0 },{'U', 0 },{'V', 0 },{'W', 0 },{'X', 0 },{'Y', 0 },{'Z', 0 },
            };

            

            //while (true)
            //{
            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey(true);
            //        switch (key.Key)
            //        {
            //            case ConsoleKey.F1:
            //                Console.WriteLine("You pressed F1!");
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        int elapsedMilliseconds = 0;
            //        int totalMilliseconds = TIME_LIMIT_SECONDS * 1000;
            //        const int INTERVAL = 100;
            //        WriteLine("Not entered");
            //        while (elapsedMilliseconds < totalMilliseconds && !quit)
            //        {
            //            // Sleep for a short period
            //            Thread.Sleep(INTERVAL);
            //            elapsedMilliseconds += INTERVAL;
            //            Write($"{elapsedMilliseconds} ");
            //            //HandleInput();

            //            //PrintRemainingTime(elapsedMilliseconds, totalMilliseconds);
            //        }
            //        break;
            //    }
            //    // Do something more useful
            //}

            MainLoop();

            foreach (var currentChar in inputContent.ToString().Where(currentChar => dataCounts.ContainsKey(currentChar)))
            {
                dataCounts[currentChar] += 1;
            }

            foreach (var keyValuePair in dataCounts.Where(k => k.Value > 0))
            {
                WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
            }

            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            var inputData = @"";

            byte[] inputBuffer = new byte[4096];
            Stream inputStream = Console.OpenStandardInput();
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            StringBuilder sb = new StringBuilder();
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine("Reading Profile");

            //Peek to see if the next character exists
            while (sr.Peek() > -1)
            {
                //Read a line from the string and display it on the
                //console
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine("Data Read Complete!");
            //Close the string
            sr.Dispose();

            //var data = ReadLine().Trim().ToUpperInvariant();
            var data = string.Empty;

            do
            {
                //input code

                //Check for exit conditions
                data = ReadLine().Trim().ToUpperInvariant();
            } while (!string.IsNullOrWhiteSpace(data));

            while (!string.IsNullOrWhiteSpace(data = Console.ReadLine()))
            {
                //but here it seems to be an infinite loop 
                foreach (var currentChar in data.Where(currentChar => dataCounts.ContainsKey(currentChar)))
                {
                    dataCounts[currentChar] += 1;
                }
            }

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
