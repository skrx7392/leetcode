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
  public class DeleteDuplicatesTests
  {
    [Test()]
    public void runTest1()
    {
      var deleteDupes = new DeleteDuplicates();
      var node2 = new ListNode(2);
      var node1 = new ListNode(1, node2);
      var node1dupe = new ListNode(1, node1);
      var result = deleteDupes.run(node1dupe);
      var resultNode = result;
      while(resultNode.next != null)
      {
        if(resultNode.val == resultNode.next.val)
        {
          Assert.Fail();
        }
        resultNode = resultNode.next;
      }
      Assert.Pass();
    }

    [Test()]
    public void runTest2()
    {
      var deleteDupes = new DeleteDuplicates();
      var node3 = new ListNode(3);
      var node3dupe = new ListNode(3, node3);
      var node2 = new ListNode(2, node3dupe);
      var node1 = new ListNode(1, node2);
      var node1dupe = new ListNode(1, node1);
      var result = deleteDupes.run(node1dupe);
      var resultNode = result;
      while (resultNode.next != null)
      {
        if (resultNode.val == resultNode.next.val)
        {
          Assert.Fail();
        }
        resultNode = resultNode.next;
      }
      Assert.Pass();
    }

    [Test()]
    public void runTest3()
    {
      var deleteDupes = new DeleteDuplicates();
      var node2 = new ListNode(1);
      var node1 = new ListNode(1, node2);
      var node1dupe = new ListNode(1, node1);
      var result = deleteDupes.run(node1dupe);
      var resultNode = result;
      while (resultNode.next != null)
      {
        if (resultNode.val == resultNode.next.val)
        {
          Assert.Fail();
        }
        resultNode = resultNode.next;
      }
      if(result.next != null)
      {
        Assert.Fail();
      }
      Assert.Pass();
    }

    [Test()]
    public void runTest4()
    {
      var deleteDupes = new DeleteDuplicates();
      var result = deleteDupes.run(null);
      if(result != null)
      {
        Assert.Fail();
      }
      Assert.Pass();
    }
  }
}