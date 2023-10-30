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
  public class CanFormArrayTests
  {
    [Test()]
    public void runTest1()
    {
      int[] arr = [15, 88];
      int[][] pieces = [[88], [15]];
      var canFormArray = new CanFormArray();
      var result = canFormArray.run(arr, pieces);
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] arr = [49, 18, 16];
      int[][] pieces = [[16, 18, 49]];
      var canFormArray = new CanFormArray();
      var result = canFormArray.run(arr, pieces);
      var expected = false;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] arr = [91, 4, 64, 78];
      int[][] pieces = [[78], [4, 64], [91]];
      var canFormArray = new CanFormArray();
      var result = canFormArray.run(arr, pieces);
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest4()
    {
      int[] arr = [100, 2, 98, 28, 44, 55, 37];
      int[][] pieces = [[28, 46, 57], [37, 19, 40, 38]];
      var canFormArray = new CanFormArray();
      var result = canFormArray.run(arr, pieces);
      var expected = false;
      Assert.AreEqual(expected, result);
    }
  }
}