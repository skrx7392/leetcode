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
  public class CountHillsAndValleysTests
  {
    [Test()]
    public void runTest1()
    {
      int[] nums = new int[] { 2, 4, 1, 1, 6, 5 };
      var countHillsAndValleys = new CountHillsAndValleys();
      int result = countHillsAndValleys.run(nums);
      Assert.AreEqual(3, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] nums = new int[] { 6, 6, 5, 5, 4, 1 };
      var countHillsAndValleys = new CountHillsAndValleys();
      int result = countHillsAndValleys.run(nums);
      Assert.AreEqual(0, result);
    }
  }
}