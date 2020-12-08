using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
  public class PasswordPolicy
  {
    private List<(char, Range)> Rules = new List<(char, Range)>();

    public PasswordPolicy(string rule)
    {
      var parts = rule.Split(" ");
      var range = new Range(parts[0]);

      var character = char.Parse(parts[1]);

      Rules.Add((character, range));
    }

    public bool IsLegal(string candidate) =>
      Rules.All((rule) =>
        {
          var (pattern, range) = rule;
          var patternCount = candidate.Count(c => c == pattern);
          return range.Contains(patternCount);
        });
  }

  public class Range
  {
    public int Min { get; set; }
    public int Max { get; set; }

    public Range(string descriptor)
    {
      var parts = descriptor.Split("-");
      Min = int.Parse(parts[0]);
      Max = int.Parse(parts[1]);
    }

    public bool Contains(int candidate) => Min <= candidate && candidate <= Max;
  }
}
