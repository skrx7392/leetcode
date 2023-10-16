using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1773 - https://leetcode.com/problems/count-items-matching-a-rule/
  /// </summary>
  public class CountItemsMatchingRule
  {
    public int run(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
      int checkingIndex = 0;
      switch(ruleKey)
      {
        case "type":
          checkingIndex = 0;
          break;
        case "color":
          checkingIndex = 1;
          break;
        case "name":
          checkingIndex = 2;
          break;
        default:
          return 0;
      }
      int counter = 0;
      for(int i = 0; i<items.Count; i++)
      {
        if (items[i][checkingIndex] == ruleValue)
        {
          counter++;
        }
      }
      return counter;
    }
  }
}
