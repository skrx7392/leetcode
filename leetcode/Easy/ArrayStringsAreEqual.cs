using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1662 - https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
  /// </summary>
  public class ArrayStringsAreEqual
  {
    public bool run(string[] word1, string[] word2)
    {
      StringBuilder sb1 = new StringBuilder();
      StringBuilder sb2 = new StringBuilder();
      int firstIndex = 0;
      int secondIndex = 0;
      while(true)
      {
        if(firstIndex < word1.Length)
        {
          sb1.Append(word1[firstIndex]);
          firstIndex++;
        }
        if(secondIndex < word2.Length)
        {
          sb2.Append(word2[secondIndex]);
          secondIndex++;
        }
        if(firstIndex >= word1.Length && secondIndex >= word2.Length)
        {
          break;
        }
      }
      if (sb1.Length != sb2.Length) return false;
      for(int i=0; i<sb1.Length; i++)
      {
        if (sb1[i] != sb2[i]) return false;
      }
      return true;
    }
  }
}
