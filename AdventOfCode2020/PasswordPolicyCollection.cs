using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
  public class PasswordValidator : Solver
  {
    private IEnumerable<(PasswordPolicy, string)> Candidates;

    public PasswordValidator()
    {
      Candidates = Parse(ReadInput("passwords_and_policies"));
    }

    public PasswordValidator(IEnumerable<string> lineItems)
    {
      Candidates = Parse(lineItems);
    }

    public IEnumerable<(PasswordPolicy, string)> LegalPasswords =>
      Candidates.Where(c =>
      {
        var (policy, password) = c;
        return policy.IsLegal(password);
      });

    private IEnumerable<(PasswordPolicy, string)> Parse(IEnumerable<string> lineItems) =>
      lineItems.Select(line =>
      {
        var parts = line.Split(": ");
        var policy = new PasswordPolicy(parts[0]);
        var password = parts[1];
        return (policy, password);
      });
  }
}
