using System;

namespace Days.Programs.AbstractClasses
{

    public abstract class Book
    {
        protected String Title;
        protected String Author;

        public Book(String title, String author)
        {
            Title = title;
            Author = author;
        }

        public abstract void Display();
    }

}
