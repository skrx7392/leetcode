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
  public class SeparateDigitsInArrayTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = new int[] { 13, 25, 83, 77 };
      var separateDigits = new SeparateDigitsInArray();
      var result = separateDigits.run(nums);
      var expected = new int[] { 1, 3, 2, 5, 8, 3, 7, 7 };
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = new int[] { 7, 1, 3, 9 };
      var separateDigits = new SeparateDigitsInArray();
      var result = separateDigits.run(nums);
      var expected = new int[] { 7, 1, 3, 9 };
      Assert.AreEqual(expected, result);
    }
  }
}