using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 94 - https://leetcode.com/problems/binary-tree-inorder-traversal/
  /// </summary>
  public class BinaryTreeInorderTraversal
  {
    public IList<int> run(TreeNode root)
    {
      List<int> result = new List<int>();
      traverse(root, result);
      return result;
    }

    private void traverse(TreeNode node, List<int> result)
    {
      if(node != null)
      {
        traverse(node.left, result);
        result.Add(node.val);
        traverse(node.right, result);
      }
    }
  }
}
