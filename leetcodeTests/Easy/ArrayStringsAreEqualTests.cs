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
  public class ArrayStringsAreEqualTests
  {
    [Test()]
    public void runTest1()
    {
      string[] s1 = ["ab", "c"];
      string[] s2 = ["a", "bc"];
      var arrayStrings = new ArrayStringsAreEqual();
      var result = arrayStrings.run(s1, s2);
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      string[] s1 = ["a", "cb"];
      string[] s2 = ["ab", "c"];
      var arrayStrings = new ArrayStringsAreEqual();
      var result = arrayStrings.run(s1, s2);
      var expected = false;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      string[] s1 = ["abc", "d", "defg"];
      string[] s2 = ["abcddefg"];
      var arrayStrings = new ArrayStringsAreEqual();
      var result = arrayStrings.run(s1, s2);
      var expected = true;
      Assert.AreEqual(expected, result);
    }
  }
}