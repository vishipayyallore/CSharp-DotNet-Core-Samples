using System;
using System.Collections.Generic;

namespace CSharp7.Demo.Common
{

    public interface IFilterData
    {
        List<int> SelectValues(List<int> numbers, Func<int, bool> filterCriteria);

        List<int> SelectValuesWithOrderBy<TKey>(List<int> numbers, Func<int, bool> filterCriteria
            , Func<int, TKey> selector);
    }

}
