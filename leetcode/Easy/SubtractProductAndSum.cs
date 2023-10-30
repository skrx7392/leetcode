using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1281 - https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
  /// </summary>
  public class SubtractProductAndSum
  {
    public int run(int n)
    {
      int product = 1;
      int sum = 0;
      while (true)
      {
        if(n == 0)
        {
          break;
        }
        sum += n % 10;
        product *= n % 10;
        n = n/10;
      }
      return product - sum;
    }
  }
}
