using System;
using System.Linq;
using AdventOfCode2020;
using Xunit;

namespace AdventTest
{
  public class PasswordPolicyTest
  {
    [Theory]
    [InlineData("1-3 a", "abcde", true)]
    [InlineData("1-3 a", "aaacde", true)]
    [InlineData("1-3 b", "cdefg", false)]
    [InlineData("2-9 c", "ccccccccc", true)]
    public void IsPolicyLegal(string rule, string sample, bool expected)
    {
      var subject = new PasswordPolicy(rule);
      Assert.Equal(expected, subject.IsLegal(sample));
    }

    [Fact]
    public void TwoLegalPasswords()
    {
      var lineItems = new string[]
      {
        "1-3 a: abcde",
        "1-3 b: cdefg",
        "2-9 c: ccccccccc",
      };
      var subject = new PasswordValidator(lineItems);

      Assert.Equal(2, subject.LegalPasswords.Count());
    }

    [Fact]
    public void LegalPasswordCountFromInput()
    {
      var subject = new PasswordValidator();
      Assert.Equal(556, subject.LegalPasswords.Count());
    }
  }
}
