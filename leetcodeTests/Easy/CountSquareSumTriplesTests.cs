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
  public class CountSquareSumTriplesTests
  {
    [Test()]
    public void runTest1()
    {
      var countSquare = new CountSquareSumTriples();
      var result = countSquare.run(5);
      Assert.AreEqual(2, result);
    }


    [Test()]
    public void runTest2()
    {
      var countSquare = new CountSquareSumTriples();
      var result = countSquare.run(10);
      Assert.AreEqual(4, result);
    }
  }
}