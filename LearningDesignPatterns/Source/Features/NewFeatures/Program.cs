using System;

namespace NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public struct Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public readonly override string ToString() => $"Id: {Id} | Name: {Name}";
    }

}
