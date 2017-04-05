using System;

namespace Days.Programs.Generics
{
    public class ArrayPrinter
    {
        public static void PrintArray<T>(T[] arrayElements)
        {
            foreach(var current in arrayElements)
            {
                Console.WriteLine($"{current}");
            }
        }
    }
}
