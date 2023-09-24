using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 26 - https://leetcode.com/problems/remove-duplicates-from-sorted-array
  /// </summary>
  public class RemoveDuplicatesFromSortedArray
  {
    public int RemoveDuplicates(int[] nums)
    {
      if(nums.Length == 0) 
        return 0;
      var firstIndex = 0;
      var secondIndex = 1;
      while(secondIndex < nums.Length)
      {
        if (nums[secondIndex] == nums[firstIndex])
        {
          secondIndex++;
          continue;
        }
        firstIndex++;
        nums[firstIndex] = nums[secondIndex];
        secondIndex++;
      }
      return firstIndex + 1;
    }
  }
}
