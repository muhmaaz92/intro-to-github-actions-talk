using System;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Empty tests pass by default in xUnit
        }

        [Fact]
        public void PassingTest()
        {
            // This logic is correct: 2 + 2 = 4
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
