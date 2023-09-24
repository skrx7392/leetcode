using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 14 - https://leetcode.com/problems/longest-common-prefix/
  /// </summary>
  public class LongestCommonPrefix
  {
    public String GetLongestCommonPrefix(string[] strs)
    {
      if (strs.Length == 0)
        return "";

      String prefix = strs[0];
      for(int i = 1; i < strs.Length; i++)
      {
        while (strs[i].IndexOf(prefix) != -0) { 
          prefix = prefix.Substring(0, prefix.Length - 1);
          if (String.IsNullOrEmpty(prefix))
            return "";
        }
      }
      return prefix;
    }
  }
}
