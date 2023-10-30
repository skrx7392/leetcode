using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 2303 - https://leetcode.com/problems/calculate-amount-paid-in-taxes/
  /// </summary>
  public class CalculateTax
  {
    public double run(int[][] brackets, int income)
    {
      double tax = 0;
      int previousBound = 0;
      for(int i=0; i<brackets.Length; i++)
      {
        int taxableIncome = brackets[i][0] - previousBound;
        if(income - taxableIncome < 0)
        {
          taxableIncome = income;
          income = 0;
        }
        tax = tax + (taxableIncome * ((double)brackets[i][1] / 100));
        income = income - taxableIncome;
        if(income <= 0)
        {
          break;
        }
        previousBound = brackets[i][0];
      }
      return tax;
    }
  }
}
