using System.Linq;
using BasicProgramming.CoreLibrary;
using static System.Console;

namespace Programs.Library
{

    /// <summary>
    /// You have been given 3 integers - l, r and k. 
    /// Find how many numbers between l and r (both inclusive) are divisible by k.
    /// </summary>
    class CountDivisors : IProgram
    {
        public void Run()
        {
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var count = 0;
            for (var iCtr = arrayValues[0]; iCtr <= arrayValues[1]; iCtr++)
            {
                if (iCtr % arrayValues[2] == 0)
                {
                    count++;
                }
            }
            WriteLine(count);
        }
    }
}
