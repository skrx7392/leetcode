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
  public class CanBeIncreasingTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = new int[] { 1, 2, 10, 5, 7 };
      var canBeIncreasing = new CanBeIncreasing();
      var result = canBeIncreasing.run(nums);
      Assert.IsTrue(result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = new int[] { 2, 3, 1, 2 };
      var canBeIncreasing = new CanBeIncreasing();
      var result = canBeIncreasing.run(nums);
      Assert.IsFalse(result);
    }

    [Test()]
    public void runTest3()
    {
      int[] nums = new int[] { 1, 1, 1 };
      var canBeIncreasing = new CanBeIncreasing();
      var result = canBeIncreasing.run(nums);
      Assert.IsFalse(result);
    }

    [Test()]
    public void runTest4()
    {
      int[] nums = new int[] { 105, 924, 32, 968 };
      var canBeIncreasing = new CanBeIncreasing();
      var result = canBeIncreasing.run(nums);
      Assert.IsTrue(result);
    }

    [Test()]
    public void runTest5()
    {
      int[] nums = new int[] { 103, 191, 918, 124, 658 };
      var canBeIncreasing = new CanBeIncreasing();
      var result = canBeIncreasing.run(nums);
      Assert.IsFalse(result);
    }
  }
}