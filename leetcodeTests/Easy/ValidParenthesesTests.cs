using NUnit.Framework;
using leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy.Tests
{
  [TestFixture()]
  public class ValidParenthesesTests
  {
    [Test()]
    public void IsValidTest1()
    {
      var validParentheses = new ValidParentheses();
      var result = validParentheses.IsValid("()");
      Assert.IsTrue(result);
    }

    [Test()]
    public void IsValidTest2()
    {
      var validParentheses = new ValidParentheses();
      var result = validParentheses.IsValid("()[]{}");
      Assert.IsTrue(result);
    }

    [Test()]
    public void IsValidTest3()
    {
      var validParentheses = new ValidParentheses();
      var result = validParentheses.IsValid("]");
      Assert.IsFalse(result);
    }
  }
}