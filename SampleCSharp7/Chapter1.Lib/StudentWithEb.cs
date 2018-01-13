using System;

namespace Chapter1.Lib
{
    public class StudentWithEb
    {
        private int _age;

        public StudentWithEb(int age) => _age = age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        ~StudentWithEb() => Console.WriteLine(" Release unmanaged code");
    }
}
