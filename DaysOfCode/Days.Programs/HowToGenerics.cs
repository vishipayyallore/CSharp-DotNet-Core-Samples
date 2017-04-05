using Days.CoreLibrary;
using Days.Programs.Generics;

namespace Days.Programs
{
    public class HowToGenerics : IProgram
    {
        public void Run()
        {
            ArrayPrinter.PrintArray(new int[] { 1, 3, 4 });
            ArrayPrinter.PrintArray(new string[] { "Shiva", "Sai", "Mathews" });
            ArrayPrinter.PrintArray(new char[] { 'A', 'B', 'C' });
        }
    }
}
