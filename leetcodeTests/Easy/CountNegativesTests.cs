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
  public class CountNegativesTests
  {
    [Test()]
    public void runTest1()
    {
      int[][] grid = [[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]];
      var countNegatives = new CountNegatives();
      var result = countNegatives.run(grid);
      var expected = 8;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[][] grid = [[3, 2], [1, 0]];
      var countNegatives = new CountNegatives();
      var result = countNegatives.run(grid);
      var expected = 0;
      Assert.AreEqual(expected, result);
    }
  }
}