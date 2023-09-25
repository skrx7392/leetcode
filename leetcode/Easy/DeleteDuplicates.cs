using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 83 - https://leetcode.com/problems/remove-duplicates-from-sorted-list/
  /// </summary>
  public class DeleteDuplicates
  {
    public ListNode run(ListNode head)
    {
      if (head == null)
      {
        return head;
      }
      var node = head;
      while(node.next != null)
      {
        if(node.val == node.next.val)
        {
          node.next = node.next.next;
          continue;
        }
        node = node.next;
      }
      return head;
    }
  }
}
