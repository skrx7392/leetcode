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
  public class SubtractProductAndSumTests
  {
    [Test()]
    public void runTest1()
    {
      int n = 234;
      var sub = new SubtractProductAndSum();
      var result = sub.run(n);
      var expected = 15;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int n = 4421;
      var sub = new SubtractProductAndSum();
      var result = sub.run(n);
      var expected = 21;
      Assert.AreEqual(expected, result);
    }
  }
}