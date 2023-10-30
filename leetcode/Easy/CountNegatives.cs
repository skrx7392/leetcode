using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1351 - https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
  /// </summary>
  public class CountNegatives
  {
    public int run(int[][] grid)
    {
      int count = 0;
      int rowLength = grid[0].Length;
      int currentNegativeIndex = rowLength - 1;

      foreach(var row in grid)
      {
        while(currentNegativeIndex >= 0 && row[currentNegativeIndex] < 0)
        {
          currentNegativeIndex--;
        }
        count = count + rowLength - 1 - currentNegativeIndex;
      }
      return count;
    }
  }
}
