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
  public class MaxDepthVPSTests
  {
    [Test()]
    public void runTest1()
    {
      string s = "(1+(2*3)+((8)/4))+1";
      var maxDepth = new MaxDepthVPS();
      var result = maxDepth.run(s);
      var expected = 3;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      string s = "(1)+((2))+(((3)))";
      var maxDepth = new MaxDepthVPS();
      var result = maxDepth.run(s);
      var expected = 3;
      Assert.AreEqual(expected, result);
    }
  }
}