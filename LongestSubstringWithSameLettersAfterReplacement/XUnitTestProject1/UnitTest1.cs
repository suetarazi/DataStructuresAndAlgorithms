using System;
using Xunit;
using LongestSubstringWithSameLettersAfterReplacement;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string testString = "aabccbb";
            int testK = 2;
            Program p = new Program();
            int actual = p.findLength(testString, testK);
            int expected = 5;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string testString = "abbcb";
            int testK = 1;
            Program p = new Program();
            int actual = p.findLength(testString, testK);
            int expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string testString = "abccde";
            int testK = 1;
            Program p = new Program();
            int actual = p.findLength(testString, testK);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}
