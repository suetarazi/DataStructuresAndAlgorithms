using System;
using Xunit;
using LongestSubstringWithKDistinctCharacters;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string testString = "araaci";
            int testDistinct = 2;
            Program p = new Program();
            int actual = p.findLength(testString, testDistinct);
            int expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string testString = "araaci";
            int testDistinct = 1;
            Program p = new Program();
            int actual = p.findLength(testString, testDistinct);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string testString = "cbbebi";
            int testDistinct = 3;
            Program p = new Program();
            int actual = p.findLength(testString, testDistinct);
            int expected = 5;
            Assert.Equal(expected, actual);
        }
    }
}
