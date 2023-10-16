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
  public class FindMiddleIndexTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = new int[] { 2, 3, -1, 8, 4 };
      var findMiddleIndex = new FindMiddleIndex();
      var result = findMiddleIndex.run(nums);
      int expected = 3;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = new int[] { 1, -1, 4 };
      var findMiddleIndex = new FindMiddleIndex();
      var result = findMiddleIndex.run(nums);
      int expected = 2;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] nums = new int[] { 2, 5 };
      var findMiddleIndex = new FindMiddleIndex();
      var result = findMiddleIndex.run(nums);
      int expected = -1;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest4()
    {
      int[] nums = new int[] { 1, 1 };
      var findMiddleIndex = new FindMiddleIndex();
      var result = findMiddleIndex.run(nums);
      int expected = -1;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest5()
    {
      int[] nums = new int[] { 3, -1 };
      var findMiddleIndex = new FindMiddleIndex();
      var result = findMiddleIndex.run(nums);
      int expected = -1;
      Assert.AreEqual(expected, result);
    }
  }
}