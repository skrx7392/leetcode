using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1446 - https://leetcode.com/problems/consecutive-characters/description/
  /// </summary>
  public class ConsecutiveCharacters
  {
    public int run(string s)
    {
      var maxCount = 0;
      var index = 0;
      char previousIndex = '0';
      var currentCounter = 0;
      while(index < s.Length)
      {
        if (s[index] == previousIndex)
        {
          currentCounter++;
        }
        else
        {
          previousIndex = s[index];
          currentCounter = 1;
        }
        maxCount = maxCount < currentCounter ? currentCounter : maxCount;
        index++;
      }
      return maxCount;
    }
  }
}
