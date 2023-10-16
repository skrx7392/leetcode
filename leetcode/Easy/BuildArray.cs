using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1920 - https://leetcode.com/problems/build-array-from-permutation/
  /// </summary>
  public class BuildArray
  {
    public int[] run(int[] nums)
    {
      for(int i=0; i<nums.Length; i++)
      {
        nums[i] = nums[i] + nums.Length * (nums[nums[i]]%nums.Length);
      }

      for(int i=0; i<nums.Length; i++)
      {
        nums[i] = nums[i] / nums.Length;
      }
      return nums;
    }
  }
}
