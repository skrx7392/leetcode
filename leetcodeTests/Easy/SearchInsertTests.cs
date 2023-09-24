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
  public class SearchInsertTests
  {
    [Test()]
    public void SearchInsertPositionTest1()
    {
      var searchInsert = new SearchInsert();
      int[] nums = new int[] { 1, 3, 5, 6 };
      int target = 5;
      int result = searchInsert.SearchInsertPosition(nums, target);
      Assert.AreEqual(2, result);
    }

    [Test()]
    public void SearchInsertPositionTest2()
    {
      var searchInsert = new SearchInsert();
      int[] nums = new int[] { 1, 3, 5, 6 };
      int target = 2;
      int result = searchInsert.SearchInsertPosition(nums, target);
      Assert.AreEqual(1, result);
    }

    [Test()]
    public void SearchInsertPositionTest3()
    {
      var searchInsert = new SearchInsert();
      int[] nums = new int[] { 1, 3, 5, 6 };
      int target = 7;
      int result = searchInsert.SearchInsertPosition(nums, target);
      Assert.AreEqual(4, result);
    }
  }
}