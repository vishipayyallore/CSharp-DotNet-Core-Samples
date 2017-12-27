using System;
using static System.Console;

namespace ClassesAndGenerics
{

    public class PerformActionV2<T> where T: IDisposable
    {
        private readonly T _value;

        public PerformActionV2(T value) => _value = value;

        public void IdentityDataType()
        {
            WriteLine($" The data type of the supplied variable is {_value.GetType()}");
        }
    }

}
