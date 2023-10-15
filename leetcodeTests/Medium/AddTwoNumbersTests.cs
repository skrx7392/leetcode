using NUnit.Framework;
using leetcode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace leetcode.Medium.Tests
{
  [TestFixture()]
  public class AddTwoNumbersTests
  {
    [Test()]
    public void runTest1()
    {
      var node3 = new ListNode(3);
      var node4 = new ListNode(4, node3);
      var node2 = new ListNode(2, node4);
      var node4dub = new ListNode(4);
      var node6dub = new ListNode(6, node4dub);
      var node5dub = new ListNode(5, node6dub);
      var addTwoNumbers = new AddTwoNumbers();
      var result = addTwoNumbers.run(node2, node5dub);
      Assert.AreEqual(7, result.val);
      Assert.AreEqual(0, result.next.val);
      Assert.AreEqual(8, result.next.next.val);
      Assert.IsNull(result.next.next.next);
    }

    [Test()]
    public void runTest2()
    {
      var node0 = new ListNode(0);
      var node0dub = new ListNode(0);
      var addTwoNumbers = new AddTwoNumbers();
      var result = addTwoNumbers.run(node0, node0dub);
      Assert.AreEqual(0, result.val);
      Assert.IsNull(result.next);
    }

    [Test()]
    public void runTest3()
    {
      var node1 = new ListNode(9);
      var node2 = new ListNode(9, node1);
      var node3 = new ListNode(9, node2);
      var node4 = new ListNode(9, node3);
      var node5 = new ListNode(9, node4);
      var node6 = new ListNode(9, node5);
      var node7 = new ListNode(9, node6);
      var node1dub = new ListNode(9);
      var node2dub = new ListNode(9, node1dub);
      var node3dub = new ListNode(9, node2dub);
      var node4dub = new ListNode(9, node3dub);
      var addTwoNumbers = new AddTwoNumbers();
      var result = addTwoNumbers.run(node7, node4dub);
      Assert.AreEqual(8, result.val);
      Assert.AreEqual(9, result.next.val);
      Assert.AreEqual(9, result.next.next.val);
      Assert.AreEqual(9, result.next.next.next.val);
      Assert.AreEqual(0, result.next.next.next.next.val);
      Assert.AreEqual(0, result.next.next.next.next.next.val);
      Assert.AreEqual(0, result.next.next.next.next.next.next.val);
      Assert.AreEqual(1, result.next.next.next.next.next.next.next.val);
      Assert.IsNull(result.next.next.next.next.next.next.next.next);
    }
  }
}