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
  public class SameTreeTests
  {
    [Test()]
    public void runTest1()
    {
      TreeNode three = new TreeNode(3, null, null);
      TreeNode two = new TreeNode(2, null, null);
      TreeNode one = new TreeNode(1, two, three);
      TreeNode threeDupe = new TreeNode(3, null, null);
      TreeNode twoDupe = new TreeNode(2, null, null);
      TreeNode oneDupe = new TreeNode(1, twoDupe, threeDupe);
      var sameTree = new SameTree();
      var result = sameTree.run(one, oneDupe);
      Assert.IsTrue(result);
    }

    [Test()]
    public void runTest2()
    {
      TreeNode two = new TreeNode(2, null, null);
      TreeNode one = new TreeNode(1, two, null);
      TreeNode twoDupe = new TreeNode(2, null, null);
      TreeNode oneDupe = new TreeNode(1, null, twoDupe);
      var sameTree = new SameTree();
      var result = sameTree.run(one, oneDupe);
      Assert.IsFalse(result);
    }

    [Test()]
    public void runTest3()
    {
      TreeNode three = new TreeNode(1, null, null);
      TreeNode two = new TreeNode(2, null, null);
      TreeNode one = new TreeNode(1, two, three);
      TreeNode threeDupe = new TreeNode(1, null, null);
      TreeNode twoDupe = new TreeNode(2, null, null);
      TreeNode oneDupe = new TreeNode(1, threeDupe, twoDupe);
      var sameTree = new SameTree();
      var result = sameTree.run(one, oneDupe);
      Assert.IsFalse(result);
    }
  }
}