using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1748 - https://leetcode.com/problems/sum-of-unique-elements/
  /// </summary>
  public class SumOfUniqueElements
  {
    public int run(int[] nums)
    {
      int[] counter = new int[101];
      for(int i=0; i<nums.Length; i++)
      {
        counter[nums[i]]++;
      }
      int sum = 0;
      for(int i=0; i<counter.Length; i++)
      {
        if (counter[i] == 1)
        {
          sum = sum + i;
        }
      }
      return sum;
    }
  }
}
