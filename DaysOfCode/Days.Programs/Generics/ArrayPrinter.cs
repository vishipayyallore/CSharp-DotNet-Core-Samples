using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Programs.Generics
{
    public class ArrayPrinter
    {
        public void PrintArray<T>(T[] arrayElements)
        {
            foreach(var current in arrayElements)
            {
                Console.WriteLine($"{current}");
            }
        }
    }
}
