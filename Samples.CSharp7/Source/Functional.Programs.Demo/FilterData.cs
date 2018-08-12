using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional.Programs.Library
{
    public class FilterData
    {

        public List<int> SelectValues(List<int> numbers, Func<int, bool> filterCriteria)
        {
            return numbers.Where(filterCriteria)
                    .ToList();
        }

    }

}
