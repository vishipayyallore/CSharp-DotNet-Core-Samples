using System;

namespace TupulesDemo.Library
{
    public class BasicTuplesDemo
    {

        public (Guid Id, string Name, int Age) GetNamedPerson()
        {
            return (Guid.NewGuid(), "Shiva Sai", 25);
        }

        public (Guid, string, int) GetUnnamedPerson()
        {
            return (Guid.NewGuid(), "Shiva Sai", 25);
        }

    }
}
