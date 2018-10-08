using System.Linq;
using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class SockMerchant
    {

        public void Execute()
        {
            WriteLine($"Sample Sort Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of Values: ");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
        }

    }

}
