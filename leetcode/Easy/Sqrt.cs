using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 69 - https://leetcode.com/problems/sqrtx
  /// </summary>
  public class Sqrt
  {
    public int run(int x)
    {
      if (x < 2)
      {
        return x;
      }
      int pivot = 0;
      int left = 2;
      int right = x / 2;
      while(left <= right)
      {
        pivot = left + (right - left)/2;
        long num = (long)pivot * pivot;
        if (num == x)
        {
          return pivot;
        }
        else if (num < x)
        {
          left = pivot + 1;
        }
        else
        {
          right = pivot - 1;
        }
      }
      return right;
    }
  }
}
