using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1539 - https://leetcode.com/problems/kth-missing-positive-number/description/
  /// </summary>
  public class KthMissingPositiveNumber
  {
    public int run(int[] arr, int k)
    {
      int counter = 0;
      int index = 0;
      int lastNum = 1;
      while (counter < k)
      {
        if (index >= arr.Length)
        {
          lastNum++;
          counter++;
        }
        else if (lastNum < arr[index])
#pragma warning disable S1871 // Two branches in a conditional structure should not have exactly the same implementation
        {
          lastNum++;
          counter++;
        }
#pragma warning restore S1871 // Two branches in a conditional structure should not have exactly the same implementation
        else if (lastNum == arr[index])
        {
          lastNum = arr[index]+1;
          index++;
        }
      }
      return lastNum - 1;
    }

    public int runBinary(int[] arr, int k)
    {
      int left = 0, right = arr.Length - 1;
      while(left <= right)
      {
        int pivot = left + (right - left) / 2;
        if (arr[pivot] - pivot - 1 < k)
        {
          left = pivot + 1;
        } else
        {
          right = pivot - 1;
        }
      }
      return left + k;      
    }
  }
}
