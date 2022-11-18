using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests
{
    public class UglyNumber
    {
        [Fact]
        public void IsUglyTests()
        {
            Algorithms.UglyNumber.IsUgly(1).Should().BeTrue();
            Algorithms.UglyNumber.IsUgly(6).Should().BeTrue();
            Algorithms.UglyNumber.IsUgly(14).Should().BeFalse();
        }
    }
}
