using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
  public class ExpenseReport : Solver
  {
    public IEnumerable<int> Expenses { get; }

    public ExpenseReport(IEnumerable<int> expenses)
    {
      Expenses = expenses;
    }

    public ExpenseReport()
    {
      Expenses = ReadInput("expense_report");
    }

    public (int, int) ExpensesThatSumTo(int target)
    {
      foreach (var cost in Expenses)
      {
        var complement = target - cost;

        if (Expenses.Contains(complement))
        {
          return (cost, complement);
        }
      }

      throw new Exception("There is no sum to the selected value.");
    }
  }
}
