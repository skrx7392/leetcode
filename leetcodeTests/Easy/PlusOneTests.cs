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
  public class PlusOneTests
  {
    [Test()]
    public void runTest1()
    {
      var plusOne = new PlusOne();
      int[] input = new int[] { 1, 2, 3 };
      var output = plusOne.run(input);
      var expected = new int[] { 1, 2, 4 };
      Assert.AreEqual(expected, output);
    }

    [Test()]
    public void runTest2()
    {
      var plusOne = new PlusOne();
      int[] input = new int[] { 4, 3, 2, 1 };
      var output = plusOne.run(input);
      var expected = new int[] { 4, 3, 2, 2 };
      Assert.AreEqual(expected, output);
    }

    [Test()]
    public void runTest3()
    {
      var plusOne = new PlusOne();
      int[] input = new int[] { 9 };
      var output = plusOne.run(input);
      var expected = new int[] { 1, 0 };
      Assert.AreEqual(expected, output);
    }

    [Test()]
    public void runTest4()
    {
      var plusOne = new PlusOne();
      int[] input = new int[] { 7, 9 };
      var output = plusOne.run(input);
      var expected = new int[] { 8, 0 };
      Assert.AreEqual(expected, output);
    }

    [Test()]
    public void runTest5()
    {
      var plusOne = new PlusOne();
      int[] input = new int[] { 9, 8, 9 };
      var output = plusOne.run(input);
      var expected = new int[] { 9, 9, 0 };
      Assert.AreEqual(expected, output);
    }
  }
}