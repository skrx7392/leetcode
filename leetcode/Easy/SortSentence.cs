using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1859 - https://leetcode.com/problems/sorting-the-sentence/
  /// </summary>
  public class SortSentence
  {
    public string run(string s)
    {
      string[] splitString = s.Split(' ');
      string[] sorted = new string[splitString.Length];
      for(int i = 0; i < splitString.Length; i++)
      {
        int index = splitString[i][splitString[i].Length - 1] - 49;
        sorted[index] = splitString[i].Substring(0, splitString[i].Length - 1);
      }
      StringBuilder sb = new StringBuilder();
      sb.Append(sorted[0]);
      for(int i = 1; i< sorted.Length; i++)
      {
        sb.Append(' ');
        sb.Append(sorted[i]);
      }
      return sb.ToString();
    }
  }
}
