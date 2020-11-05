using System;
using Xunit;
using TripletSumToZero;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { -3, 0, 1, 2, -1, 1, -2 };
            Program p = new Program();
            List<int[]> actual = p.searchTriplets(testArr);
            List<int[]> expected = new List<int[]> { [-3, 1, 2], [-2, 0, 2], [-2, 1, 1], {-1, 0, 1} };
         }

        [Fact]
        public void Test2()
        {
            int[] testArr = new int[] { -5, 2, -1, -2, 3 };
            Program p = new Program();
            List<int[]> actual = p.searchTriplets(testArr);
            List<int[]> expected = new List<int[]> { [-5, 2, 3], [-2, -1, 3] };
        }
    }
}
