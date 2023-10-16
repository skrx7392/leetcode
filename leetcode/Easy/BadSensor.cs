using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
  /// <summary>
  /// Leetcode 1826 - https://leetcode.com/problems/faulty-sensor/
  /// </summary>
  public class BadSensor
  {
    public int run(int[] sensor1, int[] sensor2)
    {
      int discrepancyIndex = -1;
      for(int i=0; i<sensor1.Length; i++)
      {
        if (sensor1[i] != sensor2[i])
        {
          discrepancyIndex = i;
          break;
        }
      }
      if(discrepancyIndex < 0) return -1;
      for(int i=discrepancyIndex; i<sensor2.Length - 1; i++)
      {
        if (sensor1[i] != sensor2[i + 1])
        {
          return 1;
        }
      }
      for (int i = discrepancyIndex; i < sensor2.Length - 1; i++)
      {
        if (sensor1[i + 1] != sensor2[i])
        {
          return 2;
        }
      }
      return -1;
    }
  }
}
