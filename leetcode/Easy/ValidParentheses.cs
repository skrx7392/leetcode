using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  // Leetcode 20 - https://leetcode.com/problems/valid-parentheses/
  public class ValidParentheses
  {
    public bool IsValid(string s)
    {
      Dictionary<char, char> bracketMap = new Dictionary<char, char>();
      bracketMap.Add(')', '(');
      bracketMap.Add('}', '{');
      bracketMap.Add(']', '[');
      Stack<char> stack = new Stack<char>();
      foreach(char c in s)
      {
        if (!bracketMap.ContainsKey(c))
        {
          stack.Push(c);
          continue;
        }
        if(!stack.Any())
        {
          return false;
        }
        if (stack.Peek() != bracketMap[c])
        {
          return false;
        }
        stack.Pop();
      }
      if (stack.Any())
        return false;
      return true;
    }
  }
}
