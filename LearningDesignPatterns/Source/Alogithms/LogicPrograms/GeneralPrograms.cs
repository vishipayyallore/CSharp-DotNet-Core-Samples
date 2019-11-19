using System.Linq;

using static System.Console;

namespace LogicPrograms
{

    public class GeneralPrograms
    {

        public void DisplayStairCase(int number)
        {
            for (var index = 1; index <= number; index++)
            {
                WriteLine(string.Concat(Enumerable.Repeat("#", index)).PadLeft(number));
            }
        }
    }

}
