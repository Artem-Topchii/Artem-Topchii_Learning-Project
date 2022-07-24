using Libraries;
using NUnit.Framework;

namespace LibraryTests
{
    public class ConditionalHelperTests
    {
        [TestCase(5, 2, 7)]
        public void ConvertHoursToMinutes_WhenInputIsPositive_ShouldReturnNumberOfMinuts(int a, int b, int expected)
        {
            int actual = ConditionalHelper.CompareTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}