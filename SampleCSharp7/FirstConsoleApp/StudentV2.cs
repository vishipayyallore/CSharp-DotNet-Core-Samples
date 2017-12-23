using System;

namespace FirstConsoleApp
{
    public class StudentV2
    {

        public StudentV2(string studentNumber)
        {
            (Name, LastName) = GetStudentDetails(studentNumber);
        }

        private string Name { get; }
        private string LastName { get; }

        public void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName = LastName;
        }

        private (string name, string surname) GetStudentDetails(string studentNumber)
        {
            if (studentNumber == null) throw new ArgumentNullException(nameof(studentNumber));
            studentNumber = string.Empty;
            var studentDetails = (name: $"{studentNumber}Dirk", surname: "Strauss");
            return studentDetails;
        }

    }
}
