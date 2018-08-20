using CSharp7.Demo.Common;
using Functional.Programs.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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


        [TestMethod]
        public void When_SelectValuesWithOrderBy_IsPassed_ValidData()
        {
            var evenNumbers = _filterData.SelectValuesWithOrderBy(_numbers, e => e % 2 == 0, e => e);

            Assert.AreEqual(5, evenNumbers.Count);
            Assert.IsTrue(IsSorted(evenNumbers));
        }

        private static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            var y = list.First();
            return list.Skip(1).All(x =>
            {
                bool b = y.CompareTo(x) < 0;
                y = x;
                return b;
            });
        }

    }

}
