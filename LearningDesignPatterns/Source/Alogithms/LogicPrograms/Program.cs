using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using static System.Console;

namespace LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------------------------------------
            var arrayItems = new int[] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0 };
            var oneCount = 0;

            foreach(var item in arrayItems)
            {
                if(item == 1)
                {
                    oneCount++;
                    continue;
                }
                Write($"{item} ");
            }

            for(var counter=0; counter < oneCount; counter++)
            {
                Write($"1 ");
            }
            //-------------------------------------------------------------

            IMath math = new Math();

            Write("Enter a number for finding Factorial: ");

            if (int.TryParse(ReadLine(), out int number))
            {
                var factorial = math.GetFactorial(number);
                WriteLine($"Factorial: {factorial}");
            }
        }

    }

}
