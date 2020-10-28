using System;
using Xunit;
using FruitsIntoBaskets;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            char[] testFruit = new char[] { 'A', 'B', 'C', 'A', 'C' };
            Program p = new Program();
            int actual = p.findLength(testFruit);
            int expected = 3;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            char[] testFruit = new char[] { 'A', 'B', 'C', 'B', 'B', 'C' };
            Program p = new Program();
            int actual = p.findLength(testFruit);
            int expected = 5;
            Assert.Equal(expected, actual);

        }
    }
}
