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
  public class FindTargetIndicesAfterSortingArrayTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = new int[] { 1, 2, 5, 2, 3 };
      var targetIndices = new FindTargetIndicesAfterSortingArray();
      var result = targetIndices.run(nums, 2);
      var expected = new List<int>() { 1, 2 };
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = new int[] { 1, 2, 5, 2, 3 };
      var targetIndices = new FindTargetIndicesAfterSortingArray();
      var result = targetIndices.run(nums, 3);
      var expected = new List<int>() { 3 };
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] nums = new int[] { 1, 2, 5, 2, 3 };
      var targetIndices = new FindTargetIndicesAfterSortingArray();
      var result = targetIndices.run(nums, 5);
      var expected = new List<int>() { 4 };
      Assert.AreEqual(expected, result);
    }
  }
}