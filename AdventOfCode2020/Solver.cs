using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
  public class Solver
{
    protected IEnumerable<int> ReadInputAsInts(string filename) =>
      ReadInput(filename)
        .Select((i) => int.Parse(i));

    protected IEnumerable<string> ReadInput(string filename)
    {
      using var reader = new StreamReader($"./input/{filename}");
      return reader
        .ReadToEnd()
        .Split(Environment.NewLine);
    }
  }
}
