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


        public void CalculateAndShowValues(List<int> numbers, Func<int, int> performAction)
        {
            numbers.ForEach(number =>
            {
                WriteLine(performAction(number));
            });
        }

    }

}
