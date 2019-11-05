namespace V6.NewFeatures.Models
{

    // Read-only auto-properties. C# 6.0
    public class Student
    {

        public string FirstName { get; }

        public string LastName { get; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }

}
