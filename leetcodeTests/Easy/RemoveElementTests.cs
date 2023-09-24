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
  public class RemoveElementTests
  {
    [Test()]
    public void RemoveElementsTest1()
    {
      var removeElement = new RemoveElement();
      var input = new int[] { 3, 2, 2, 3 };
      var result = removeElement.RemoveElements(input, 3);
      Assert.AreEqual(2, result);
      for(int i=0; i<result; i++)
      {
        if (input[i] == 3)
          Assert.Fail();
      }
      Assert.Pass();
    }

    [Test()]
    public void RemoveElementsTest2()
    {
      var removeElement = new RemoveElement();
      var input = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
      var result = removeElement.RemoveElements(input, 2);
      Assert.AreEqual(5, result);
      for (int i = 0; i < result; i++)
      {
        if (input[i] == 2)
          Assert.Fail();
      }
      Assert.Pass();
    }

    [Test()]
    public void RemoveElementsTest3()
    {
      var removeElement = new RemoveElement();
      var input = new int[] { 1 };
      var result = removeElement.RemoveElements(input, 1);
      Assert.AreEqual(0, result);
      for (int i = 0; i < result; i++)
      {
        if (input[i] == 1)
          Assert.Fail();
      }
      Assert.Pass();
    }

    [Test()]
    public void RemoveElementsTest4()
    {
      var removeElement = new RemoveElement();
      var input = new int[] { 3, 3 };
      var result = removeElement.RemoveElements(input, 3);
      Assert.AreEqual(0, result);
      for (int i = 0; i < result; i++)
      {
        if (input[i] == 3)
          Assert.Fail();
      }
      Assert.Pass();
    }
  }
}