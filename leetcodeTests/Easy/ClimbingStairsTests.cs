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
  public class ClimbingStairsTests
  {
    [Test()]
    public void runTest1()
    {
      var n = 7;
      var climbingStairs = new ClimbingStairs();
      int result = climbingStairs.run(n);
      Assert.AreEqual(21, result);
    }

    [Test()]
    public void runTest2()
    {
      var n = 2;
      var climbingStairs = new ClimbingStairs();
      int result = climbingStairs.run(n);
      Assert.AreEqual(2, result);
    }

    [Test()]
    public void runTest3()
    {
      var n = 3;
      var climbingStairs = new ClimbingStairs();
      int result = climbingStairs.run(n);
      Assert.AreEqual(3, result);
    }
  }
}