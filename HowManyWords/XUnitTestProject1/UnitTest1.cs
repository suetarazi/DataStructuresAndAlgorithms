using System;
using Xunit;
using HowManyWords;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string testString = "How many eggs are in a half-dozen, 13?";
            Program p = new Program();
            int actual = p.howMany(testString);
            int expected = 7;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            string testString = "He is a good programmer, he won 865 competitions, but sometimes he dont. What do you think? All test-cases should pass. Done-done?";
            Program p = new Program();
            int actual = p.howMany(testString);
            int expected = 21;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test3()
        {
            string testString = "jds dsaf lkdf kdsa fkldsf, adsbf ldka ads? asd bfdal ds bf[l. akf dhj ds 878 dwa WE DE 7475 dsfh ds RAMU 748 dj.";
            Program p = new Program();
            int actual = p.howMany(testString);
            int expected = 21;
            Assert.Equal(expected, actual);

        }
    }
}
