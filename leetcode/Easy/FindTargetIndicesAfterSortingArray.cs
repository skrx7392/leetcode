using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 2089 - https://leetcode.com/problems/find-target-indices-after-sorting-array/
  /// </summary>
  public class FindTargetIndicesAfterSortingArray
  {
    public IList<int> run(int[] nums, int target)
    {
      int countOfTargets = 0;
      int lessThanTarget = 0;
      for(int i=0; i<nums.Length; i++)
      {
        if (nums[i] < target)
        {
          lessThanTarget++;
        }
        if (nums[i] == target)
        {
          countOfTargets++;
        }
      }
      var result = new List<int>();
      for(int i=0; i<countOfTargets; i++)
      {
        result.Add(lessThanTarget++);
      }
      return result;
    }
  }
}
