using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
  public class Solver
{
    protected IEnumerable<int> ReadInput(string filename)
    {
      using var reader = new StreamReader($"./input/{filename}");
      return reader
        .ReadToEnd()
        .Split(Environment.NewLine)
        .Select((i) => int.Parse(i));
    }
  }
}
