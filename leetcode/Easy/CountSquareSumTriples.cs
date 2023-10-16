using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1925 - https://leetcode.com/problems/count-square-sum-triples/
  /// </summary>
  public class CountSquareSumTriples
  {
    public int run(int n)
    {
      int firstNum = 1;
      int secondNum = 2;
      int counter = 0;
      while(firstNum < n)
      {
        while(secondNum < n)
        {
          double thirdNum = Math.Sqrt(firstNum * firstNum + secondNum * secondNum);
          if (thirdNum <= n && thirdNum % 1 == 0)
          {
            counter++;
          }
          secondNum++;
        }
        firstNum++;
        secondNum = firstNum + 1;
      }
      return counter*2;
    }
  }
}
