using System.Collections.Generic;

namespace FirstConsoleApp
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<int> CourseCodes { get; set; }

        public void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName = LastName;
        }

    }
}
