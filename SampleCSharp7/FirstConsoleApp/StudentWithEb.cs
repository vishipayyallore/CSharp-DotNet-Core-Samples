using static System.Console;

namespace FirstConsoleApp
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

        ~StudentWithEb() => WriteLine(" Release unmanaged code");
    }
}
