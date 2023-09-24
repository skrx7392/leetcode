using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 35 - https://leetcode.com/problems/search-insert-position/
  /// </summary>
  public class SearchInsert
  {
    public int SearchInsertPosition(int[] nums, int target)
    {
      int pivot, startingIndex = 0, endingIndex = nums.Length - 1;
      while (startingIndex <= endingIndex)
      {
        pivot = startingIndex + (endingIndex - startingIndex) / 2;
        if (nums[pivot] == target) { 
          return pivot; 
        }
        if (target < nums[pivot]) { 
          endingIndex = pivot - 1; 
        }
        else { 
          startingIndex = pivot + 1; 
        }
      }
      return startingIndex;
    }
  }
}
