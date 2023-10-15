using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 100 - https://leetcode.com/problems/same-tree/
  /// </summary>
  public class SameTree
  {
    public bool run(TreeNode p, TreeNode q)
    {
      if(p == null && q == null)
      {
        return true;
      }
      else if(p == null || q == null)
      {
        return false;
      }
      if(p.val != q.val)
      {
        return false;
      }
      else
      {
        var left = run(p.left, q.left);
        var right = run(p.right, q.right);
        return left && right;
      }
    }
  }
}
