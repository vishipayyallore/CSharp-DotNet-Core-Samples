using System;

namespace TupulesDemo.Library
{
    public class BasicTuplesDemo
    {

        public (Guid Id, string Name, int Age) GetNamedPerson()
        {
            return (Guid.NewGuid(), "Named Person", 18);
        }

        public (Guid, string, int) GetUnnamedPerson()
        {
            return (Guid.NewGuid(), "Unnamed Person", 21);
        }

    }
}
