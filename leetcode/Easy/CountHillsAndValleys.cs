using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 2210 - https://leetcode.com/problems/count-hills-and-valleys-in-an-array/
  /// </summary>
  public class CountHillsAndValleys
  {
    public int run(int[] nums)
    {
      int hillsAndValleys = 0;
      int previous = nums[0];
      for(int i = 1; i< nums.Length - 1; i++)
      {
        int nextNonEqualIndex = i + 1;
        while (true)
        {
          if (nextNonEqualIndex >= nums.Length)
          {
            return hillsAndValleys;
          }
          if (nums[i] == nums[nextNonEqualIndex])
          {
            nextNonEqualIndex++;
          }
          else
            break;
        }
        int next = nums[nextNonEqualIndex];
        if ((nums[i] > previous && nums[i] > next) || (nums[i] < previous && nums[i] < next))
        {
          hillsAndValleys++;
          previous = nums[i];
          i = nextNonEqualIndex-1;
        }
      }
      return hillsAndValleys;
    }
  }
}
