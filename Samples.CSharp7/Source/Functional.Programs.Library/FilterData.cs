using CSharp7.Demo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Functional.Programs.Library
{
    public class FilterData : IFilterData
    {

        public List<int> SelectValues(List<int> numbers, Func<int, bool> filterCriteria)
        {
            return numbers.Where(filterCriteria)
                    .ToList();
        }

        public List<int> SelectValuesWithOrderBy<TKey>(List<int> numbers, Func<int, bool> filterCriteria
            , Func<int, TKey> selector)
        {
            return numbers
                    .Where(filterCriteria)
                    .OrderBy(selector)
                    .ToList();
        }

        public List<int> GetNumbersDouble(Func<List<int>, List<int>> doubleNumbers, List<int> numbers)
        {
            return doubleNumbers(numbers);
        }


        public void CalculateAndShowValues(List<int> numbers, bool avoidZeroValues, Func<int, int> performAction)
        {
            WriteLine($"");
            numbers.ForEach(number =>
            {
                var returnValue = performAction(number);
                if(avoidZeroValues && returnValue == 0)
                {
                    return;
                }
                Write( $"{number} => {returnValue} ");
            });
        }

    }

}
