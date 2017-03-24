using static System.Console;

namespace Days.Programs.InheritanceDemo
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void PrintPerson()
        {
            WriteLine( $"Name: {lastName}, {firstName}\nID: {id}");
        }
    }
}
