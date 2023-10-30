using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1460 - https://leetcode.com/problems/make-two-arrays-equal-by-reversing-subarrays/
  /// </summary>
  public class CanBeEqual
  {
    public bool run(int[] target, int[] arr)
    {
      var numArray = new int[1001];
      for(int i = 0; i < target.Length; i++)
      {
        numArray[target[i]] = numArray[target[i]] + 1;
      }
      for(int i=0; i<arr.Length; i++)
      {
        numArray[arr[i]] = numArray[arr[i]] - 1;
        if (numArray[arr[i]] < 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}
