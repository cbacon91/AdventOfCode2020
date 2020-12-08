using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
  public class ExpenseReport : Solver
  {
    public IEnumerable<int> Expenses { get; }
    private int TARGET = 2020;

    public ExpenseReport(IEnumerable<int> expenses)
    {
      Expenses = expenses;
    }

    public ExpenseReport()
    {
      Expenses = ReadInput("expense_report");
    }

    public int[] SummableExpenses2()
    {
      foreach (var cost in Expenses)
      {
        var complement = TARGET - cost;

        if (Expenses.Contains(complement))
        {
          return new int[] { cost, complement };
        }
      }

      throw new Exception("There is no sum to the selected value.");
    }

    public int[] SummableExpenses3()
    {
      foreach (var cost in Expenses)
      {
        foreach(var complement in Expenses.Except(new int[] { cost }))
        {
          var tertiary = TARGET - cost - complement;

          if (Expenses.Contains(tertiary))
          {
            return new int[] { cost, complement, tertiary };
          }
        }
      }

      throw new Exception("There is no sum to the selected value.");
    }

  }
}
