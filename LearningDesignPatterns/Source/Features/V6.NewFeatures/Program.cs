using V6.NewFeatures.Models;
using static System.Console;

namespace V6.NewFeatures
{

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Shiva", "Sai");
            WriteLine(student);

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
