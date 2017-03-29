using static System.Console;

namespace Days.Programs.AbstractClasses
{

    public class NovelBook : Book
    {
        int _price;

        public NovelBook(string title, string author, int price) : base(title, author)
        {
            _price = price;
        }

        public override void Display()
        {
            WriteLine($"Title: {Title}");
            WriteLine($"Author: {Author}");
            WriteLine($"Price: {_price}");
        }
    }

}
