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
  public class CalculateTaxTests
  {
    [Test()]
    public void runTest1()
    {
      int[][] brackets = [[3, 50], [7, 10], [12, 25]];
      int income = 10;
      var taxes = new CalculateTax();
      var result = taxes.run(brackets, income);
      var expected = 2.65;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[][] brackets = [[1, 0], [4, 25], [5, 50]];
      int income = 2;
      var taxes = new CalculateTax();
      var result = taxes.run(brackets, income);
      var expected = 0.25;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[][] brackets = [[2, 50]];
      int income = 0;
      var taxes = new CalculateTax();
      var result = taxes.run(brackets, income);
      var expected = 0.00;
      Assert.AreEqual(expected, result);
    }
  }
}