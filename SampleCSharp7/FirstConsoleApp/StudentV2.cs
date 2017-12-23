using System.Collections.Generic;

namespace FirstConsoleApp
{
    public class StudentV2
    {

        public StudentV2(string studentNumber)
        {
            (Name, LastName) = GetStudentDetails(studentNumber);
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public List<int> CourseCodes { get; private set; }

        public void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName = LastName;
        }

        private (string name, string surname) GetStudentDetails(string studentNumber)
        {
            var studentDetails = (name: "Dirk", surname: "Strauss");
            return studentDetails;
        }

    }
}
