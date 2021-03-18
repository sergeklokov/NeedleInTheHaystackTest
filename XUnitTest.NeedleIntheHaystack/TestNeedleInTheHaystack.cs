using System;
using Xunit;
using NeedleInTheHaystack;

namespace XUnitTest.NeedleIntheHaystack
{
    public class TestNeedleInTheHaystack
    {
        [Theory]
        [InlineData("aslkfjdsklfjls;adfk", "asl")]
        [InlineData("aslkfjdsklfjls;adfk", "dfk")]
        [InlineData("aslkf", null)]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        public void isNeedleInHaystockFoundSequential(string hay, string needle)
        {
            Assert.True(NeedleInTheHaystack.Program.isNeedleInHaystock(hay, needle));
        }

        [Theory]
        [InlineData("aslkfjdsklfjl", "kfss")]
        [InlineData("aslkfjdsklfjls;adfk", "test")]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        public void isNeedleInHaystockFoundSequentialNegative(string hay, string needle)
        {
            Assert.False(NeedleInTheHaystack.Program.isNeedleInHaystock(hay, needle));
        }

    }
}
