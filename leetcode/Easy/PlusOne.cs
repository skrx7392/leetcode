using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 66 - https://leetcode.com/problems/plus-one
  /// </summary>
  public class PlusOne
  {
    public int[] run(int[] digits)
    {
      if (digits[digits.Length - 1] != 9)
      {
        digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
        return digits;
      }
      int carryover = digits[digits.Length - 1] == 9 ? 1 : 0;
      int[] result = new int[digits.Length + 1];
      int index = digits.Length - 1;
      while(index >= 0)
      {
        result[index + 1] = (digits[index] + carryover) % 10;
        if (digits[index] + carryover > 9) {
          carryover = 1;
        }
        else
        {
          carryover = 0;
        }
        index--;
      }
      if(carryover == 0)
      {
        return result.Skip(1).ToArray();
      }
      result[0] = carryover;
      return result;
    }
  }
}
