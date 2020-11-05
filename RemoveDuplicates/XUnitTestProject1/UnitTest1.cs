using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using RemoveDuplicates;
using Program = RemoveDuplicates.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 2, 3, 3, 3, 6, 9, 9 };
            Program p = new Program();
            int actual = p.remove(testArr);
            int expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] testArr = new int[] { 2, 2, 2, 11 };
            Program p = new Program();
            int actual = p.remove(testArr);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] testArr = new int[] { 3, 2, 3, 6, 3, 10, 9, 3 };
            int testKey = 3;
            Program p = new Program();
            int actual = p.removeKey(testArr, testKey);
            int expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            int[] testArr = new int[] { 2, 11, 2, 2, 1 };
            int testKey = 2;
            Program p = new Program();
            int actual = p.removeKey(testArr, testKey);
            int expected = 2;
            Assert.Equal(expected, actual);
        }
    }
}
