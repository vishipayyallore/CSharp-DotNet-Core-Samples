using System;
using System.Collections.Generic;

namespace FirstConsoleApp
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<int> CourseCodes { get; set; }

        public Student()
        {
            Name = string.Empty;
            LastName = string.Empty;
            CourseCodes = new List<int>();
        }
        //public void Deconstruct(out string name, out string lastName)
        //{
        //    name = Name;
        //    lastName = LastName;
        //}

        public int GetNameLength()
        {
            return (Name.Length + LastName.Length) > 0 ? Name.Length + LastName.Length : throw new Exception("First name and last name is empty");
        }

    }
}
