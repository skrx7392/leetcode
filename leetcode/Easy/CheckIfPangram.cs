using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1832 - https://leetcode.com/problems/check-if-the-sentence-is-pangram/
  /// </summary>
  public class CheckIfPangram
  {
    public bool run(string sentence)
    {
      int counter = 0;
      bool[] alphabetArray = new bool[26];
      foreach(var alphabet in sentence)
      {
        if(!alphabetArray[alphabet - 'a'])
        {
          alphabetArray[alphabet - 'a'] = true;
          counter++;
        }
        if (counter == 26)
          return true;
      }
      return false;
    }
  }
}
