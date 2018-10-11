using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CSharp7.Logic.Programs
{

    public class PlusMinus
    {

        static List<int> SelectArrayValues(int[] numbers, Func<int, bool> filterCriteria)
        {
            return numbers.Where(filterCriteria)
                    .ToList();
        }

        public void Execute(int numberOfItems, int[] arrayValues)
        {

            var values = SelectArrayValues(arrayValues, e => e > 0);
            WriteLine(string.Format("{0:F6}", (values.Count / (numberOfItems * 1.0))));

            values = SelectArrayValues(arrayValues, e => e < 0);
            WriteLine(string.Format("{0:F6}", (values.Count / (numberOfItems * 1.0))));

            values = SelectArrayValues(arrayValues, e => e == 0);
            WriteLine(string.Format("{0:F6}", (values.Count / (numberOfItems * 1.0))));
        }

    }

}
