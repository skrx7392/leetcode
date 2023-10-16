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
  public class StringSwapTests
  {
    [Test()]
    public void runTest1()
    {
      string s1 = "bank";
      string s2 = "kanb";
      var stringSwap = new StringSwap();
      var result = stringSwap.run(s1, s2);
      Assert.IsTrue(result);
    }

    [Test()]
    public void runTest2()
    {
      string s1 = "attack";
      string s2 = "defend";
      var stringSwap = new StringSwap();
      var result = stringSwap.run(s1, s2);
      Assert.IsFalse(result);
    }

    [Test()]
    public void runTest3()
    {
      string s1 = "kelb";
      string s2 = "kelb";
      var stringSwap = new StringSwap();
      var result = stringSwap.run(s1, s2);
      Assert.IsTrue(result);
    }
  }
}