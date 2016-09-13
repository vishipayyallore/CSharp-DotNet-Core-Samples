using static System.Console;

namespace SingleDArray
{

    public class PrintReverse
    {

        #region Methods.
        public static void Run(int[] arrayElements)
        {
            Write("Output: ");
            for (var iCtr = arrayElements.Length - 1; iCtr >= 0; iCtr--)
            {
                Write($"{arrayElements[iCtr]} ");
            }
            WriteLine();
        }
        #endregion

    }

}
