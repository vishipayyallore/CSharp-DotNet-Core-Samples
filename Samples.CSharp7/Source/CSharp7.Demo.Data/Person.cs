using System;

namespace CSharp7.Demo.Data
{

    public class Person
    {

        public Person(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }

        // Read only auto property
        public Guid Id { get; private set; } = Guid.NewGuid();

        public string Name { get; set; }

        // Auto-Property Initializers
        public int Age { get; } = 18;

        public float Salary { get; set; }
    }

}
