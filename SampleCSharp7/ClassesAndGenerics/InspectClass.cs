using System.Collections.Generic;

namespace ClassesAndGenerics
{
    public class InspectClass<T> : IListClassProperties<T>
    {
        public List<string> GetPropertyList()
        {
            throw new System.NotImplementedException();
        }
    }
}