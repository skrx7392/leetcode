using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1614 - https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
  /// </summary>
  public class MaxDepthVPS
  {
    public int run(string s)
    {
      int maxDepth = 0;
      int currentDepth = 0;
      foreach(char c in s)
      {
        if(c == '(')
        {
          currentDepth++;
          if(maxDepth < currentDepth)
          {
            maxDepth = currentDepth;
          }
        }
        else if(c == ')')
        {
          currentDepth--;
        }
      }
      return maxDepth;
    }
  }
}
