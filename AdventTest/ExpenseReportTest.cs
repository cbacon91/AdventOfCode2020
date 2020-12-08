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
      var subject = new ExpenseReport(new int[] { 1721, 979, 366, 299, 675, 1456 });
      Assert.Equal(new int[] { 1721, 299 }, subject.SummableExpenses2());
    }

    [Fact]
    public void TestExpenseSum3()
    {
      var subject = new ExpenseReport(new int[] { 1721, 979, 366, 299, 675, 1456 });
      Assert.Equal(new int[] { 979, 366, 675 }, subject.SummableExpenses3());
    }

    [Fact]
    public void TestExpenseSumWithInput()
    {
      var subject = new ExpenseReport();
      Assert.Equal(new int[] { 1632, 388 }, subject.SummableExpenses2());
    }

    [Fact]
    public void TestExpenseSumWithInput3()
    {
      var subject = new ExpenseReport();
      Assert.Equal(new int[] { 1607, 196, 217 }, subject.SummableExpenses3());
    }
  }
}
