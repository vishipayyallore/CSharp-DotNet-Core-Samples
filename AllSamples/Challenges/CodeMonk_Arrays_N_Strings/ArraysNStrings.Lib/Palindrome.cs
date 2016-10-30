using static System.Console;

namespace ArraysNStrings.Lib
{

    public class Palindrome
    {
        #region Methods
        public static void Run()
        {
            var numberOfItems = int.Parse(ReadLine().Trim());
            for (; numberOfItems > 0; numberOfItems--)
            {
                var data = ReadLine().Trim();
                var output = $"YES {((data.Length % 2 == 0) ? "EVEN" : "ODD")}";
                var jCtr = 0;
                for (var iCtr = data.Length - 1; iCtr >= 0; iCtr--, jCtr++)
                {
                    if (data[iCtr].Equals(data[jCtr])) continue;
                    output = "NO";
                    break;
                }
                WriteLine($"{output}");
            }
        }
        #endregion
    }

}
