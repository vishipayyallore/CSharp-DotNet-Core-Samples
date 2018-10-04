using Functional.Programs.Library;
using System.Collections.Generic;

namespace CSharp7.DemoApp.ExecuteMethods
{
    public class ShowFilteredDataDemo
    {
        private readonly List<int> _numbers = new List<int> { 3, 8, 4, 6, 1, 7, 5, 2, 9, 10 };
        private readonly FilterData _filterDataObject = new FilterData();
        private readonly ExecuteMethodsHelper _executeMethodsHelper;

        public ShowFilteredDataDemo()
        {
            _executeMethodsHelper = new ExecuteMethodsHelper();
        }


        public ShowFilteredDataDemo ShowSimpleFilteredDataDemo()
        {
            _executeMethodsHelper.ShowHeader($"ShowFilteredDataDemo::ShowSimpleFilteredDataDemo ----- -----");

            _filterDataObject.CalculateAndShowValues(_numbers, false, x => x + 2);
            _filterDataObject.CalculateAndShowValues(_numbers, false, x => x * x);
            _filterDataObject.CalculateAndShowValues(_numbers, false, x => (x * x * x));
            
            // Odd Numbers
            _filterDataObject.CalculateAndShowValues(_numbers, true, x =>
            {
                return (x % 2 == 1) ? x : 0;
            });
            
            // Even Numbers
            _filterDataObject.CalculateAndShowValues(_numbers, true, x =>
            {
                return (x % 2 == 0) ? x : 0;
            });

            return this;
        }

    }
}
