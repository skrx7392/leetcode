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
  public class BuildArrayTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = new int[] { 0, 2, 1, 5, 3, 4 };
      var buildArray = new BuildArray();
      int[] result = buildArray.run(nums);
      int[] expected = new int[] { 0, 1, 2, 4, 5, 3 };
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = new int[] { 5, 0, 1, 2, 3, 4 };
      var buildArray = new BuildArray();
      int[] result = buildArray.run(nums);
      int[] expected = new int[] { 4, 5, 0, 1, 2, 3 };
      Assert.AreEqual(expected, result);
    }
  }
}