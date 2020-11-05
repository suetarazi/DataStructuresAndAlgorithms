using System;
using Xunit;
using SlotMachine2;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<string> testInput = new List<string> { "4", "712", "246", "365", "312" };
            Program p = new Program();
            int actual = p.slotWheels(testInput);
            int expected = 15;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            List<string> testInput = new List<string> { "4", "137", "364", "115", "724" };
            Program p = new Program();
            int actual = p.slotWheels(testInput);
            int expected = 14;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            List<string> testInput = new List<string> { "4", "1112", "1111", "1211", "1111" };
            Program p = new Program();
            int actual = p.slotWheels(testInput);
            int expected = 5;
            Assert.Equal(expected, actual);
        }
    }
}
