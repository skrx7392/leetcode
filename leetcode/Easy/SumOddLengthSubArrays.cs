using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1588 - https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
  /// </summary>
  public class SumOddLengthSubArrays
  {
    public int run(int[] arr)
    {
      int n = arr.Length;
      int result = 0;

      for(int i = 0; i < n; i++)
      {
        int left = i;
        int right = n - i - 1;
        result = result + arr[i] * (left/2 + 1) * (right/2 + 1);
        result = result + arr[i] * ((left + 1)/2) * ((right + 1)/2);
      }

      return result;
    }
  }
}
