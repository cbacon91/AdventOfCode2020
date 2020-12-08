using System;
using AdventOfCode2020;
using Xunit;

namespace AdventTest
{
  public class ExpenseReportTest
  {
    [Fact]
    public void TestExpenseSum()
    {
      var subject = new ExpenseReport(new int[] { 20, 2000 });
      Assert.Equal((20, 2000), subject.ExpensesThatSumTo(2020));
    }

    [Fact]
    public void TestExpenseSumWithInput()
    {
      var subject = new ExpenseReport();
      Assert.Equal((1632, 388), subject.ExpensesThatSumTo(2020));
    }
  }
}
