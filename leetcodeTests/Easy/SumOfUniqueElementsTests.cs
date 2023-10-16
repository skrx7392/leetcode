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
  public class SumOfUniqueElementsTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = [1, 2, 3, 2];
      var sumOfUniqueElements = new SumOfUniqueElements();
      var result = sumOfUniqueElements.run(nums);
      var expected = 4;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = [1, 1, 1, 1, 1];
      var sumOfUniqueElements = new SumOfUniqueElements();
      var result = sumOfUniqueElements.run(nums);
      var expected = 0;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] nums = [1, 2, 3, 4, 5];
      var sumOfUniqueElements = new SumOfUniqueElements();
      var result = sumOfUniqueElements.run(nums);
      var expected = 15;
      Assert.AreEqual(expected, result);
    }
  }
}