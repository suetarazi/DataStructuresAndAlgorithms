using System;
using Xunit;
using MaximumSumSubarrayOfSizeK;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] TestInput = new int[] { 2, 1, 5, 1, 3, 2 };
            int k = 3;
            Program p = new Program();
            int actual = p.findMaxSumSubArray(k, TestInput);
            int expected = 9;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            int[] TestInput = new int[] { 2, 3, 4, 1, 5 };
            int k = 2;
            Program p = new Program();
            int actual = p.findMaxSumSubArray(k, TestInput);
            int expected = 7;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] TestInput = new int[] { 2, 1, 5, 1, 3, 2 };
            int k = 3;
            Program p = new Program();
            int actual = p.findMaxSumSubArrayOptimized(k, TestInput);
            int expected = 9;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test4()
        {
            int[] TestInput = new int[] { 2, 3, 4, 1, 5 };
            int k = 2;
            Program p = new Program();
            int actual = p.findMaxSumSubArrayOptimized(k, TestInput);
            int expected = 7;
            Assert.Equal(expected, actual);
        }
    }
}
