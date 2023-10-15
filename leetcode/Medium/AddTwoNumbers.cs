using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
  /// <summary>
  /// Leetcode 2 - https://leetcode.com/problems/add-two-numbers/
  /// </summary>
  public class AddTwoNumbers
  {
    public ListNode run(ListNode l1, ListNode l2)
    {
      ListNode result = new ListNode();
      ListNode currentNode = null;

      int carryover = 0;
      while(true)
      {
        if(l1 == null && l2 == null) { 
          if(carryover == 1)
          {
            currentNode.next = new ListNode(1);
          }
          break;
        }
        if (currentNode == null)
        {
          currentNode = result;
        }
        else
        {
          currentNode.next = new ListNode();
          currentNode = currentNode.next;
        }
        int num1 = 0, num2 = 0;
        if(l1 != null)
        {
          num1 = l1.val;
        }
        if(l2 != null)
        {
          num2 = l2.val;
        }
        int sum = num1 + num2 + carryover;
        carryover = 0;
        if(sum > 9)
        {
          carryover = 1;
          sum = sum % 10;
        }
        currentNode.val = sum;
        if(l1 != null)
        {
          l1 = l1.next;
        }
        if(l2 != null)
        {
          l2 = l2.next;
        }
      }

      return result;
    }
  }
}
