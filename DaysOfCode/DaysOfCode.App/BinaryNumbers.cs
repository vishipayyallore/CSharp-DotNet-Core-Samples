using System.Collections.Generic;

namespace DaysOfCode.App
{

    public class BinaryNumbers
    {

        #region Methods
        public static string DecimalToBinary(int number)
        {
            var stackData = new Stack<int>();

            while (number > 0)
            {
                stackData.Push(number % 2);
                number /= 2;
            }

            return string.Join("", stackData.ToArray());
        }
        #endregion

    }
}
