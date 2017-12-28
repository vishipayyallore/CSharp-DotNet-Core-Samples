using System.Collections.Generic;
using System.Linq;

namespace ClassesAndGenerics
{
    public class InspectClass<T> : IListClassProperties
    {
        private readonly T _classToInspect;

        public InspectClass(T classToInspect)
        {
            _classToInspect = classToInspect;
        }

        public List<string> GetPropertyList()
        {
            return _classToInspect.GetType()
                .GetProperties()
                .Select(property => property.Name)
                .ToList();
        }

    }
}