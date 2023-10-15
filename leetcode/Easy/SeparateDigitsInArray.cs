using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 2553 - https://leetcode.com/problems/separate-the-digits-in-an-array/
  /// </summary>
  public class SeparateDigitsInArray
  {
    public int[] run(int[] nums)
    {
      StringBuilder sb = new StringBuilder();
      foreach(int i in nums)
      {
        sb.Append(i);
      }
      var result = new int[sb.Length];
      String finalString = sb.ToString();
      for(int i=0; i<result.Length; i++)
      {
        result[i] = (int)Char.GetNumericValue(finalString[i]);
      }
      return result;
    }
  }
}
