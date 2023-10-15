using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 101 - https://leetcode.com/problems/symmetric-tree/
  /// </summary>
  public class SymmetricTree
  {
    public bool run(TreeNode root)
    {
      return helper(root.left, root.right);
    }

    private bool helper(TreeNode p, TreeNode q)
    {
      if (p == null && q == null)
      {
        return true;
      }
      else if (p == null || q == null)
      {
        return false;
      }
      return (p.val == q.val) && helper(p.left, q.right) && helper(p.right, q.left);
    }
  }
}
