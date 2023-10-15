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
  public class BinaryTreeInorderTraversalTests
  {
    [Test()]
    public void runTest1()
    {
      TreeNode three = new TreeNode(3, null, null);
      TreeNode two = new TreeNode(2, three, null);
      TreeNode one = new TreeNode(1, null, two);
      var inorderTraversal = new BinaryTreeInorderTraversal();
      var result = inorderTraversal.run(one);
      var expected = new List<int>() { 1, 3, 2 };
      for(int i=0; i<expected.Count; i++)
      {
        if (result[i] != expected[i])
        {
          Assert.Fail();
        }
      }
      Assert.Pass();
    }

    [Test()]
    public void runTest2()
    {
      var inorderTraversal = new BinaryTreeInorderTraversal();
      var result = inorderTraversal.run(null);
      var expected = new List<int>();
      for (int i = 0; i < expected.Count; i++)
      {
        if (result[i] != expected[i])
        {
          Assert.Fail();
        }
      }
      Assert.Pass();
    }

    [Test()]
    public void runTest3()
    {
      TreeNode one = new TreeNode(1, null, null);
      var inorderTraversal = new BinaryTreeInorderTraversal();
      var result = inorderTraversal.run(one);
      var expected = new List<int>() { 1 };
      for (int i = 0; i < expected.Count; i++)
      {
        if (result[i] != expected[i])
        {
          Assert.Fail();
        }
      }
      Assert.Pass();
    }
  }
}