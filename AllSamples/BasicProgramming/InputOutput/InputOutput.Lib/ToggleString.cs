using static System.Console;

namespace InputOutput.Lib
{
    public class ToggleString
    {
        #region Variables.
        private static int _output = 0;
        #endregion

        #region Methods.
        public static void Run()
        {
            var data = ReadLine().Trim();

            foreach (var currentChar in data)
            {
                if ((currentChar >= 65 && currentChar <= 90))
                {
                    _output = currentChar + 32;
                }
                else if ((currentChar >= 97 && currentChar <= 122))
                {
                    _output = currentChar - 32;
                }
                Write($"{(char)_output} ");
            }
        }
        #endregion
    }
}
