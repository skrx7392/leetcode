using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  // LeetCode Problem 13 - https://leetcode.com/problems/roman-to-integer/
  public class RomanToInteger
  {
    private Dictionary<string, int> stringNumberMap;

    public RomanToInteger() { 
      this.stringNumberMap = new Dictionary<String, int>();
      stringNumberMap.Add("I", 1);
      stringNumberMap.Add("V", 5);
      stringNumberMap.Add("X", 10);
      stringNumberMap.Add("L", 50);
      stringNumberMap.Add("C", 100);
      stringNumberMap.Add("D", 500);
      stringNumberMap.Add("M", 1000);
      stringNumberMap.Add("IV", 4);
      stringNumberMap.Add("IX", 9);
      stringNumberMap.Add("XL", 40);
      stringNumberMap.Add("XC", 90);
      stringNumberMap.Add("CD", 400);
      stringNumberMap.Add("CM", 900);
    }

    public int convertRomanToInteger(String input)
    {
      int total = 0;
      int i = 0;
      while(i < input.Length)
      {
        if(i < input.Length - 1)
        {
          String doubleSymbol = input.Substring(i, 2);
          if(stringNumberMap.ContainsKey(doubleSymbol))
          {
            total += stringNumberMap[doubleSymbol];
            i += 2;
            continue;
          }
        }
        String singleSymbol = input[i].ToString();
        total += stringNumberMap[singleSymbol];
        i += 1;
      }      
      return total;
    }
  }
}

/**
 * 
 * 
 * 
 */