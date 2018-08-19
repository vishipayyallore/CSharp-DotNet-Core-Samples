using System;

namespace GenericsDemo.Library
{

    public class GenericTryParse
    {

        public int TryParse(string value)
        {
            // Inline out variable declaration
            int.TryParse(value, out int parsedValue);
            return parsedValue;
        }

    }

}
