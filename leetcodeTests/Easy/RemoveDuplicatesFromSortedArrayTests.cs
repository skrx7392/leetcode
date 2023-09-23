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
  public class RemoveDuplicatesFromSortedArrayTests
  {
    [Test()]
    public void RemoveDuplicatesTest1()
    {
      var removeDuplicates = new RemoveDuplicatesFromSortedArray();
      var input = new int[] { 1, 1, 2 };
      var output = removeDuplicates.RemoveDuplicates(input);
      Assert.AreEqual(2, output);
      for(int i = 1; i < output; i++)
      {
        if (input[i] <= input[i-1])
          Assert.Fail();
      }
      Assert.Pass();
    }

    [Test()]
    public void RemoveDuplicatesTest2()
    {
      var removeDuplicates = new RemoveDuplicatesFromSortedArray();
      var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
      var output = removeDuplicates.RemoveDuplicates(input);
      Assert.AreEqual(5, output);
      for (int i = 1; i < output; i++)
      {
        if (input[i] <= input[i - 1])
          Assert.Fail();
      }
      Assert.Pass();
    }
  }
}