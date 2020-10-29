using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Calculate2dArrayDistance;
using Program = Calculate2dArrayDistance.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string testString = "O__;_XT;___";
            Program p = new Program();
            int actual = p.calculateDistance(testString);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}
