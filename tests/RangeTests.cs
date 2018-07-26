using api.Controllers;
using System;
using Xunit;
using System.Linq;

namespace tests
{
    public class RangeTests
    {
        [Fact]
        public void CouldShouldControlNumberOfResults()
        {
            var range = new Range { Count = 3 };

            var generated = range.Of(() => "");

            Assert.Equal(3, generated.Count());
        }

        [Fact]
        public void TestBuild()
        {
            int num = 0;

            Assert.Equal(0, num);
        }
    }
}
