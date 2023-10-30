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
  public class KthMissingPositiveNumberTests
  {
    [Test()]
    public void runTest1()
    {
      int[] arr = [2, 3, 4, 7, 11];
      int k = 5;
      var kthMissing = new KthMissingPositiveNumber();
      var result = kthMissing.run(arr, k);
      var expected = 9;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] arr = [1, 2, 3, 4];
      int k = 2;
      var kthMissing = new KthMissingPositiveNumber();
      var result = kthMissing.run(arr, k);
      var expected = 6;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runBinaryTest1()
    {
      int[] arr = [2, 3, 4, 7, 11];
      int k = 5;
      var kthMissing = new KthMissingPositiveNumber();
      var result = kthMissing.runBinary(arr, k);
      var expected = 9;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runBinaryTest2()
    {
      int[] arr = [1, 2, 3, 4];
      int k = 2;
      var kthMissing = new KthMissingPositiveNumber();
      var result = kthMissing.runBinary(arr, k);
      var expected = 6;
      Assert.AreEqual(expected, result);
    }
  }
}