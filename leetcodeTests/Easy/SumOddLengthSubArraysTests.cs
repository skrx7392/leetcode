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
  public class SumOddLengthSubArraysTests
  {
    [Test()]
    public void runTest()
    {
      int[] arr = [1, 4, 2, 5, 3];
      var sumOdd = new SumOddLengthSubArrays();
      var result = sumOdd.run(arr);
      var expected = 58;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] arr = [1, 2];
      var sumOdd = new SumOddLengthSubArrays();
      var result = sumOdd.run(arr);
      var expected = 3;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] arr = [10, 11, 12];
      var sumOdd = new SumOddLengthSubArrays();
      var result = sumOdd.run(arr);
      var expected = 66;
      Assert.AreEqual(expected, result);
    }
  }
}