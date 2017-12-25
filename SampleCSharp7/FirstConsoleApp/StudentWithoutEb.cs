using static System.Console;

namespace FirstConsoleApp
{
    public class StudentWithoutEb
    {
        private int _age;

        public StudentWithoutEb(int age)
        {
            _age = age;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //Finalizers
        ~StudentWithoutEb()
        {
            WriteLine(" Release unmanaged code");
        }

    }
}
