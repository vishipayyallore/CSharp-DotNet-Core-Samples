using System;

namespace CSharp7.Demo.Data
{

    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public int Age { get; set; }

        public float Salary { get; set; }
    }

}
