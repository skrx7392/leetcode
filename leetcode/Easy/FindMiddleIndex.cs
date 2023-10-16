using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1991 - https://leetcode.com/problems/find-the-middle-index-in-array/
  /// </summary>
  public class FindMiddleIndex
  {
    public int run(int[] nums)
    {
      int sum = 0;
      for(int i=0; i<nums.Length; i++)
      {
        sum += nums[i];
      }
      int countingSum = 0;
      for(int i=0; i<nums.Length ; i++)
      {
        int rightSum = sum - countingSum - nums[i];
        if(rightSum == countingSum)
        {
          return i;
        }
        countingSum += nums[i];
      }
      return -1;
    }
  }
}
