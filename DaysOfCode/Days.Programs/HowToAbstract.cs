using Days.CoreLibrary;
using Days.Programs.AbstractClasses;
using static System.Console;

namespace Days.Programs
{

    public class HowToAbstract : IProgram
    {
        public void Run()
        {
            var title = ReadLine();
            var author = ReadLine();
            var price = int.Parse(ReadLine().Trim());
            Book newNovel = new NovelBook(title, author, price);
            newNovel.Display();
        }
    }
}
