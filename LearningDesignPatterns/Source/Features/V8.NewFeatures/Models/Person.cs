using System;

namespace V8.NewFeatures.Models
{
    public struct Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public readonly override string ToString() => $"Id: {Id} | Name: {Name}";
    }

}
