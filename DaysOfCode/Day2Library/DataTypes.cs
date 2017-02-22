using static System.Console;

namespace Day2Library
{

    public class DataTypes
    {

        const int number1 = 4;
        const double value1 = 4.0;
        const string firstPart = "Hello World, ";

        public static void Run()
        {
            int number2 = int.Parse(ReadLine().Trim());
            double value2 = double.Parse(ReadLine().Trim());
            string secondPart = ReadLine().Trim();

            WriteLine($"{number1 + number2}");
            WriteLine($"{value1 + value2}");
            WriteLine($"{firstPart + secondPart}");
        }

    }

}
