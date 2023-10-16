using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1909 - https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
  /// </summary>
  public class CanBeIncreasing
  {
    public bool run(int[] nums)
    {
      bool removedNumber = false;
      int checkingIndex = 0;
      for(int i=1; i<nums.Length; i++)
      {
        if (nums[i] <= nums[checkingIndex])
        {
          if (removedNumber)
          {
            return false;
          }
          removedNumber = true;
          if (i > 1 && nums[i - 2] >= nums[i])
          {
            checkingIndex = i - 1;
          }
          else checkingIndex = i;
        }
        else checkingIndex = i;
      }
      return true;
    }
  }
}
