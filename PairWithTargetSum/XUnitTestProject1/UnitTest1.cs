using System;
using Xunit;
using PairWithTargetSum;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 1, 2, 3, 4, 6 };
            int testTarget = 6;
            Program p = new Program();
            int[] actual = p.search(testArr, testTarget);
            int[] expected = new int[] { 1, 3 };
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            int[] testArr = new int[] { 2, 5, 9, 11 };
            int testTarget = 11;
            Program p = new Program();
            int[] actual = p.search(testArr, testTarget);
            int[] expected = new int[] { 0, 2 };
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test3()
        {
            int[] testArr = new int[] { 1, 2, 3, 4, 6 };
            int testTarget = 6;
            Program p = new Program();
            int[] actual = p.useHashtableToSearch(testArr, testTarget);
            int[] expected = new int[] { 1, 3 };
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test4()
        {
            int[] testArr = new int[] { 2, 5, 9, 11 };
            int testTarget = 11;
            Program p = new Program();
            int[] actual = p.useHashtableToSearch(testArr, testTarget);
            int[] expected = new int[] { 0, 2 };
            Assert.Equal(expected, actual);

        }
    }
}
