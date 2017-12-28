using System.Collections.Generic;

namespace ClassesAndGenerics
{

    public interface IListClassProperties<T>
    {
        List<string> GetPropertyList();
    }
}