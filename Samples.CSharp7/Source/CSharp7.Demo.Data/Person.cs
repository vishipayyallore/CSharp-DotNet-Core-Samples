using System;
using System.Collections.Generic;
using System.Linq;

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
        // Also Read Only
        public int Age { get; } = 18;

        public float Salary { get; set; }

        // Dictionay Initializers
        Dictionary<string, string> Languages { get; } = new Dictionary<string, string>
        {
            {"1", "English" },
            {"2", "Hindi" },
            {"3", "French" }
        };

        // Dictionay Initializers
        Dictionary<string, string> SpecializedIn { get; } = new Dictionary<string, string>
        {
            ["1"] = "C#",
            ["2"] = "Angular"
        };


        // Property returning Tuple
        public (Guid Id, string Name) PersonInformation => (Id, Name);
        

        // Expression-bodied function
        public override string ToString() => $"{Id}, {Name} {Age} {Salary} {string.Join(" ", Languages.Values.ToArray())} " +
            $"{string.Join(" ", SpecializedIn.Values.ToArray())} ";
    }

}
