using NUnit.Framework;
using leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy.Tests
{
  [TestFixture()]
  public class RomanToIntegerTests
  {
    [Test()]
    public void convertIII()
    {
      var romanToInteger = new RomanToInteger();
      int num = romanToInteger.convertRomanToInteger("III");
      Assert.AreEqual(3, num);
    }

    [Test()]
    public void convertLVIII()
    {
      var romanToInteger = new RomanToInteger();
      int num = romanToInteger.convertRomanToInteger("LVIII");
      Assert.AreEqual(58, num);
    }

    [Test()]
    public void convertMCMXCIV()
    {
      var romanToInteger = new RomanToInteger();
      int num = romanToInteger.convertRomanToInteger("MCMXCIV");
      Assert.AreEqual(1994, num);
    }
  }
}