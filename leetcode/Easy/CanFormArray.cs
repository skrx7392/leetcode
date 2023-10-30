using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1640 - https://leetcode.com/problems/check-array-formation-through-concatenation/
  /// </summary>
  public class CanFormArray
  {
    public bool run(int[] arr, int[][] pieces)
    {
      int[] numberArray = new int[101];
      for(int i=0; i<arr.Length; i++)
      {
        numberArray[arr[i]] = i;
      }
      foreach(var row in pieces)
      {
        if (numberArray[row[0]] == 0 && arr[0] != row[0])
        {
          return false;
        }
        int counter = numberArray[row[0]];
        for(int i=0; i<row.Length; i++)
        {
          if (numberArray[row[i]] != counter)
          {
            return false;
          }
          counter++;
        }
      }
      return true;
    }
  }
}
