using Functional.Programs.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7.DemoApp.ExecuteMethods
{
    public class ShowFilteredDataDemo
    {
        private List<int> numbers = new List<int> { 3, 8, 4, 6, 1, 7, 5, 2, 9, 10 };
        private readonly FilterData filterDataObject = new FilterData();
        private readonly ExecuteMethodsHelper _executeMethodsHelper;

        public ShowFilteredDataDemo()
        {
            _executeMethodsHelper = new ExecuteMethodsHelper();
        }


        public ShowFilteredDataDemo ShowSimpleFilteredDataDemo()
        {
            _executeMethodsHelper.ShowHeader($"ShowFilteredDataDemo::ShowSimpleFilteredDataDemo ----- -----");

            filterDataObject.CalculateAndShowValues(numbers, false, x => x + 2);
            filterDataObject.CalculateAndShowValues(numbers, false, x => x * x);
            filterDataObject.CalculateAndShowValues(numbers, false, x => (x * x * x));
            
            // Odd Numbers
            filterDataObject.CalculateAndShowValues(numbers, true, x =>
            {
                return (x % 2 == 1) ? x : 0;
            });
            
            // Even Numbers
            filterDataObject.CalculateAndShowValues(numbers, true, x =>
            {
                return (x % 2 == 0) ? x : 0;
            });

            return this;
        }

    }
}
