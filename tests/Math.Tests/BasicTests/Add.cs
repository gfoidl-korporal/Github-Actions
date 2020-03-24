using System.Collections.Generic;
using NUnit.Framework;

namespace Math.Tests.BasicTests
{
    [TestFixture]
    public class Add
    {
        [Test, TestCaseSource(nameof(Two_summands___correct_sum_TestCases))]
        public int Two_summands___correct_sum(int a, int b)
        {
            var sut = new Basic();

            int actual = sut.Add(a, b);

            return actual;
        }
        //---------------------------------------------------------------------
        private static IEnumerable<TestCaseData> Two_summands___correct_sum_TestCases()
        {
            yield return new TestCaseData(3, 4).Returns(7);
        }
    }
}
