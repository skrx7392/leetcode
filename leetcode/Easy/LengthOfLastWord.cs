using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 58 - https://leetcode.com/problems/length-of-last-word/
  /// </summary>
  public class LengthOfLastWord
  {
    public int run(string s)
    {
      if (s.Length == 1) return 1;
      int firstOccurrence = 0;
      int lastOccurrence = 0;
      for(int i=s.Length-1; i>=0; i--)
      {
        if (s[i] == ' ')
        {
          if (firstOccurrence == 0)
            continue;
          lastOccurrence = i + 1;
          break;
        }
        else
        {
          if(firstOccurrence == 0)
            firstOccurrence = i + 1;
        }
      }
      return firstOccurrence - lastOccurrence;
    }
  }
}
