using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 28 - https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
  /// </summary>
  public class IndexOfFirstOccurrenceInString
  {
    public int StrStr(string haystack, string needle)
    {
      if(needle.Length > haystack.Length)
      {
        return -1;
      }
      int haystackIndex = 0;
      int needleIndex = 0;
      while(haystackIndex < haystack.Length)
      {
        if (haystack[haystackIndex] == needle[needleIndex])
        {
          int subHaystackIndex = haystackIndex;
          while(subHaystackIndex < haystack.Length)
          {
            if (haystack[subHaystackIndex] == needle[needleIndex])
            {
              subHaystackIndex++;
              needleIndex++;
            }
            else
            {
              needleIndex = 0;
              break;
            }
            if (needleIndex == needle.Length)
              return haystackIndex;
          }
          haystackIndex++;
        }
        else
        {
          haystackIndex++;
          needleIndex = 0;
        }
      }
      return -1;
    }
  }
}
