using System;
using AdventOfCode2020;
using Xunit;

namespace AdventTest
{
  public class UnitTest1
  {
    [Fact]
    public void TestSetup()
    {
      Assert.Equal(2020, new TestMe().Setup());
    }
  }
}
