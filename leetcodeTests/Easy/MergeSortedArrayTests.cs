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
  public class MergeSortedArrayTests
  {
    [Test()]
    public void runTest1()
    {
      var mergeSortedArray = new MergeSortedArray();
      var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
      var nums2 = new int[] { 2, 5, 6 };
      var m = 3;
      var n = 3;
      mergeSortedArray.run(nums1, m, nums2, n);
      var result = new int[] { 1, 2, 2, 3, 5, 6 };
      for(int i = 0; i<result.Length; i++)
      {
        Assert.AreEqual(result[i], nums1[i]);
      }
    }

    [Test()]
    public void runTest2()
    {
      var mergeSortedArray = new MergeSortedArray();
      var nums1 = new int[] { 1 };
      var nums2 = new int[] { };
      var m = 1;
      var n = 0;
      mergeSortedArray.run(nums1, m, nums2, n);
      var result = new int[] { 1 };
      for (int i = 0; i < result.Length; i++)
      {
        Assert.AreEqual(result[i], nums1[i]);
      }
    }

    [Test()]
    public void runTest3()
    {
      var mergeSortedArray = new MergeSortedArray();
      var nums1 = new int[] { 0 };
      var nums2 = new int[] { 1 };
      var m = 0;
      var n = 1;
      mergeSortedArray.run(nums1, m, nums2, n);
      var result = new int[] { 1 };
      for (int i = 0; i < result.Length; i++)
      {
        Assert.AreEqual(result[i], nums1[i]);
      }
    }
  }
}