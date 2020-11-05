using System;
using Xunit;
using SmallestSubarrayWithAGivenSum;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] TestInput = new int[] { 2, 1, 5, 2, 3, 2 };
            int testS = 7;
            Program p = new Program();
            int actual = p.findMinSubArray(testS, TestInput);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] TestInput = new int[] { 2, 1, 5, 2, 8 };
            int testS = 7;
            Program p = new Program();
            int actual = p.findMinSubArray(testS, TestInput);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] TestInput = new int[] { 3, 4, 1, 1, 6 };
            int testS = 8;
            Program p = new Program();
            int actual = p.findMinSubArray(testS, TestInput);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}
