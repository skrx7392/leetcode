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
  public class LongestCommonPrefixTests
  {
    [Test()]
    public void GetLongestCommonPrefixTest1()
    {
      var longestCommonPrefix = new LongestCommonPrefix();
      string[] strs = new string[] { "flight", "flow", "flower" };
      var result = longestCommonPrefix.GetLongestCommonPrefix(strs);
      Assert.AreEqual("fl", result);
    }

    [Test()]
    public void GetLongestCommonPrefixTest2()
    {
      var longestCommonPrefix = new LongestCommonPrefix();
      string[] strs = new string[] { "dog", "racecar", "car" };
      var result = longestCommonPrefix.GetLongestCommonPrefix(strs);
      Assert.AreEqual("", result);
    }
  }
}