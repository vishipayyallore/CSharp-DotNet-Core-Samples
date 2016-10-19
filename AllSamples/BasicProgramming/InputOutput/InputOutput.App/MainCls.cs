using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace InputOutput.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            var data = "Shiva Sai";
            var output = 0;
            foreach (var currentChar in data)
            {
                if ((currentChar >= 65 && currentChar <= 90))
                {
                    output = currentChar + 32;
                }
                else if ((currentChar >= 97 && currentChar <= 122))
                {
                    output = currentChar - 32;
                }
                Write($"{(char)output} ");
            }
            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
