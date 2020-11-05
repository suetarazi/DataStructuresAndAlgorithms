using System;
using Xunit;
using SquareSortedArray;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { -2, -1, 0, 2, 3 };
            Program p = new Program();
            int[] actual = p.BruteForceMakeSquares(testArr);
            int[] expected = new int[] { 0, 1, 4, 4, 9 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] testArr = new int[] { -3, -1, 0, 1, 2 };
            Program p = new Program();
            int[] actual = p.BruteForceMakeSquares(testArr);
            int[] expected = new int[] { 0, 1, 1, 4, 9 };
            Assert.Equal(expected, actual);
        }

        
        [Fact]
        public void Test3()
        {
            int[] testArr = new int[] { -2, -1, 0, 2, 3 };
            Program p = new Program();
            int[] actual = p.makeSquaresTwoPointer(testArr);
            int[] expected = new int[] { 0, 1, 4, 4, 9 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            int[] testArr = new int[] { -3, -1, 0, 1, 2 };
            Program p = new Program();
            int[] actual = p.makeSquaresTwoPointer(testArr);
            int[] expected = new int[] { 0, 1, 1, 4, 9 };
            Assert.Equal(expected, actual);
        }
    }
}
