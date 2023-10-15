using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class TreeNode
  {
    public int val { get; set; }
    public TreeNode left { get; set; }
    public TreeNode right { get; set; }

    public TreeNode(int val, TreeNode left, TreeNode right)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }
}
