using NUnit.Framework;

namespace Math.Tests.BasicTests
{
    [TestFixture]
    public class Add
    {
        [Test]
        public void Two_summands___correct_sum()
        {
            var sut = new Basic();

            int actual = sut.Add(3, 8);

            Assert.AreEqual(11, actual);
        }
    }
}
