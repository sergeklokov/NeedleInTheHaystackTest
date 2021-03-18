using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NeedleInTheHaystack;

namespace XUnitTest.NeedleIntheHaystack
{
    public class TestRegexMethod
    {
        [Theory]
        [InlineData("aslkfjdsklfjls;adfk", "asl")]
        [InlineData("aslkfjdsklfjls;adfk", "dfk")]
        [InlineData("aslkf", null)]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        public void isNeedleInHaystockFoundSequentialRegex(string hay, string needle)
        {
            Assert.True(NeedleInTheHaystack.Program.isNeedleInHaystockByRegex(hay, needle));
        }

        [Theory]
        [InlineData("aslkfjdsklfjl", "kfss")]
        [InlineData("aslkfjdsklfjls;adfk", "test")]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        public void isNeedleInHaystockFoundSequentialRegexNegative(string hay, string needle)
        {
            Assert.False(NeedleInTheHaystack.Program.isNeedleInHaystockByRegex(hay, needle));
        }
    }
}
