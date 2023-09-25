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
  public class SqrtTests
  {
    [Test()]
    public void runTest1()
    {
      var x = 4;
      var sqrt = new Sqrt();
      var result = sqrt.run(x);
      Assert.AreEqual(2, result);
    }

    [Test()]
    public void runTest2()
    {
      var x = 8;
      var sqrt = new Sqrt();
      var result = sqrt.run(x);
      Assert.AreEqual(2, result);
    }

    [Test()]
    public void runTest3()
    {
      var x = 2147395599;
      var sqrt = new Sqrt();
      var result = sqrt.run(x);
      Assert.AreEqual(46339, result);
    }

    [Test()]
    public void runTest4()
    {
      var x = 1;
      var sqrt = new Sqrt();
      var result = sqrt.run(x);
      Assert.AreEqual(1, result);
    }
  }
}