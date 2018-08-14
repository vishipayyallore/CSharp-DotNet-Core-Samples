using CSharp7.Demo.Common;
using Functional.Programs.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Functional.Programs.Tests
{
    [TestClass]
    public class FilterDataTests
    {
        readonly List<int> _numbers = new List<int> { 3, 8, 4, 6, 1, 7, 5, 2, 9, 10 };
        readonly IFilterData _filterData;

        public FilterDataTests()
        {
            _filterData = new FilterData();
        }

        [TestMethod]
        public void When_SelectValues_IsPassed_ValidData()
        {
            var evenNumbers = _filterData.SelectValues(_numbers, e => e % 2 == 0);

            Assert.AreEqual(5, evenNumbers.Count);
        }

        [TestMethod]
        public void When_SelectValues_IsPassed_ValidData_ForOddNumbers()
        {
            var oddNumbers = _filterData.SelectValues(_numbers, e => e % 2 == 1);

            Assert.AreEqual(5, oddNumbers.Count);
        }

    }

}
