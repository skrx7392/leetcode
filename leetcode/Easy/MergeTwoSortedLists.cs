using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 21 - https://leetcode.com/problems/merge-two-sorted-lists/
  /// </summary>
  public class MergeTwoSortedLists
  {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
      if(list1 == null)
        return list2;
      else if(list2 == null)
        return list1;
      else if(list1.val < list2.val)
      {
        list1.next = MergeTwoLists(list1.next, list2);
        return list1;
      }
      else
      {
        list2.next = MergeTwoLists(list2.next, list1);
        return list2;
      }
    }
  }
}
