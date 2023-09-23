using NUnit.Framework;
using leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace leetcode.Easy.Tests
{
  [TestFixture()]
  public class MergeTwoSortedListsTests
  {
    [Test()]
    public void MergeTwoListsTest1()
    {
      var four = new ListNode(4);
      var two = new ListNode(2, four);
      var one = new ListNode(1, two);
      var fourdupe = new ListNode(4);
      var three = new ListNode(3, fourdupe);
      var onedupe = new ListNode(1, three);
      var mergeLists = new MergeTwoSortedLists();
      var result = mergeLists.MergeTwoLists(one, onedupe);
      var node = result;
      int previousVal = -500;
      while(node != null)
      {
        if(node.val < previousVal)
        {
          Assert.Fail();
        }
        node = node.next;
      }
      Assert.Pass();
    }

    [Test()]
    public void MergeTwoListsTest2()
    {
      var mergeLists = new MergeTwoSortedLists();
      var result = mergeLists.MergeTwoLists(null, null);
      var node = result;
      int previousVal = -500;
      while (node != null)
      {
        if (node.val < previousVal)
        {
          Assert.Fail();
        }
        node = node.next;
      }
      Assert.Pass();
    }

    [Test()]
    public void MergeTwoListsTest3()
    {
      var zero = new ListNode(0);
      var mergeLists = new MergeTwoSortedLists();
      var result = mergeLists.MergeTwoLists(null, zero);
      var node = result;
      int previousVal = -500;
      while (node != null)
      {
        if (node.val < previousVal)
        {
          Assert.Fail();
        }
        node = node.next;
      }
      Assert.Pass();
    }
  }
}