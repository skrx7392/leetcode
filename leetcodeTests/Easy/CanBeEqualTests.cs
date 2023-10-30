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
  public class CanBeEqualTests
  {
    [Test()]
    public void runTest1()
    {
      int[] target = [1, 2, 3, 4];
      int[] arr = [2, 4, 1, 3];
      var canBeEqual = new CanBeEqual();
      var result = canBeEqual.run(target, arr);
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] target = [7];
      int[] arr = [7];
      var canBeEqual = new CanBeEqual();
      var result = canBeEqual.run(target, arr);
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] target = [3, 7, 9];
      int[] arr = [3, 7, 11];
      var canBeEqual = new CanBeEqual();
      var result = canBeEqual.run(target, arr);
      var expected = false;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest4()
    {
      int[] target = [1, 2, 2, 3];
      int[] arr = [1, 1, 2, 3];
      var canBeEqual = new CanBeEqual();
      var result = canBeEqual.run(target, arr);
      var expected = false;
      Assert.AreEqual(expected, result);
    }
  }
}