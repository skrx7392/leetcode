using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1790 - https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/
  /// </summary>
  public class StringSwap
  {
    public bool run(string s1, string s2)
    {
      char firstChar = 'A';
      char secondChar = 'A';
      bool swapped = false;
      for(int i=0; i<s1.Length; i++)
      {
        if (s1[i] != s2[i])
        {
          if(swapped)
          {
            return false;
          }
          if(firstChar == 'A')
          {
            firstChar = s1[i];
            secondChar = s2[i];
          }
          else
          {
            if(firstChar != s2[i] || secondChar != s1[i])
            {
              return false;
            }
            swapped = true;
          }
        }
      }
      return swapped || firstChar == 'A';
    }
  }
}
