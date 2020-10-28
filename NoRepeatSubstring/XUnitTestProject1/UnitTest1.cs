using System;
using Xunit;
using NoRepeatSubstring;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string testString = "aabccbb";
            Program p = new Program();
            int actual = p.findLength(testString);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string testString = "abbbb";
            Program p = new Program();
            int actual = p.findLength(testString);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string testString = "abccde";
            Program p = new Program();
            int actual = p.findLength(testString);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}
