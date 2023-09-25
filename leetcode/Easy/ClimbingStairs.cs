using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 70 - https://leetcode.com/problems/climbing-stairs/
  /// </summary>
  public class ClimbingStairs
  {
    private readonly Dictionary<int, int> fibMap = new Dictionary<int, int>();
    public int run(int n)
    {
      int result = fib(n + 1);
      return result;
    }

    public int fib(int n)
    {
      if (n == 0)
      {
        return 0;
      }
      if (n == 1)
      {
        return 1;
      }
      if(fibMap.ContainsKey(n))
      {
        return fibMap[n];
      }
      int result = fib(n - 1) + fib(n - 2);
      if(!fibMap.ContainsKey(result))
      {
        fibMap.Add(n, result);
      }
      return result;
    }
  }
}
