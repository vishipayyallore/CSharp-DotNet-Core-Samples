using Days.CoreLibrary;
using System.Collections.Generic;
using static System.Console;

namespace Days.Programs
{

    public class BinaryNumbers : IProgram
    {

        #region Methods
        private static string DecimalToBinary(int number)
        {
            var stackData = new Stack<int>();

            while (number > 0)
            {
                stackData.Push(number % 2);
                number /= 2;
            }

            return string.Join("", stackData.ToArray());
        }

        public void Run()
        {
            var number = int.Parse(ReadLine().Trim());

            var binaryData = DecimalToBinary(number);
            var highestNumber = 0;

            foreach (var binary in binaryData.Split('0'))
            {
                if (highestNumber < binary.Length)
                {
                    highestNumber = binary.Length;
                }
            }

            WriteLine($"{highestNumber}");
        }
        #endregion

    }
}
