using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 88 - https://leetcode.com/problems/merge-sorted-array/
  /// </summary>
  public class MergeSortedArray
  {
    public void run(int[] nums1, int m, int[] nums2, int n)
    {
      m = m - 1; n = n-1;
      for(int i = nums1.Length - 1; i >= 0; i--)
      {
        if(n < 0)
        {
          nums1[i] = nums1[m];
          m = m - 1;
        }
        else if(m < 0)
        {
          nums1[i] = nums2[n];
          n = n - 1;
        }
        else if (nums2[n] >= nums1[m])
        {
          nums1[i] = nums2[n];
          n = n - 1;
        }
        else
        {
          nums1[i] = nums1[m];
          m = m - 1;
        }
      }
    }
  }
}
