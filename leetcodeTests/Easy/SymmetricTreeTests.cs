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
  public class SymmetricTreeTests
  {
    [Test()]
    public void runTest1()
    {
      TreeNode four = new TreeNode(4, null, null);
      TreeNode three = new TreeNode(3, null, null);
      TreeNode two = new TreeNode(2, three, four);
      TreeNode fourdupe = new TreeNode(4, null, null);
      TreeNode threedupe = new TreeNode(3, null, null);
      TreeNode twodupe = new TreeNode(2, fourdupe, threedupe);
      TreeNode one = new TreeNode(1, two, twodupe);
      var symmetricTree = new SymmetricTree();
      var result = symmetricTree.run(one);
      Assert.IsTrue(result);
    }

    [Test()]
    public void runTest2()
    {
      TreeNode three = new TreeNode(3, null, null);
      TreeNode two = new TreeNode(2, null, three);
      TreeNode threedupe = new TreeNode(3, null, null);
      TreeNode twodupe = new TreeNode(2, null, threedupe);
      TreeNode one = new TreeNode(1, two, twodupe);
      var symmetricTree = new SymmetricTree();
      var result = symmetricTree.run(one);
      Assert.IsFalse(result);
    }

    [Test()]
    public void runTest3()
    {
      TreeNode five = new TreeNode(5, null, null);
      TreeNode four = new TreeNode(4, null, null);
      TreeNode three = new TreeNode(3, four, five);
      TreeNode fourdupe = new TreeNode(4, null, null);
      TreeNode threedupe = new TreeNode(3, null, fourdupe);
      TreeNode two = new TreeNode(2, three, threedupe);
      var symmetricTree = new SymmetricTree();
      var result = symmetricTree.run(two);
      Assert.IsFalse(result);
    }
  }
}