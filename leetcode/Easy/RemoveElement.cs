using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 27 - https://leetcode.com/problems/remove-element
  /// </summary>
  public class RemoveElement
  {
    public int RemoveElements(int[] nums, int val)
    {
      if(nums.Length == 0)
        return 0;
      int firstIndex = 0;
      int secondIndex = nums.Length;
      while(firstIndex < secondIndex)
      {
        if (nums[firstIndex] == val)
        {
          nums[firstIndex] = nums[secondIndex - 1];
          secondIndex--;
          continue;
        }
        firstIndex++;
      }
      return firstIndex;
    }
  }
}
