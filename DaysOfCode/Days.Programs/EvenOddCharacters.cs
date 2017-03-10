using Days.CoreLibrary;
using System.Text;
using static System.Console;

namespace Days.Programs
{
    public class EvenOddCharacters : IProgram
    {
        public void Run()
        {
            var iterations = int.Parse(ReadLine().Trim());
            while (iterations-- > 0)
            {
                var word = ReadLine().Trim();
                var oddData = new StringBuilder(" ");
                for (var iCtr = 0; iCtr < word.Length; iCtr += 2)
                {
                    Write($"{word[iCtr]}");
                    if ((iCtr + 1) < word.Length)
                    {
                        oddData.Append(word[iCtr + 1]);
                    }
                }
                WriteLine($"{oddData.ToString()}");
            }
        }
    }

}
