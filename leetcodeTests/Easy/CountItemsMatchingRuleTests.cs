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
  public class CountItemsMatchingRuleTests
  {
    [Test()]
    public void runTest1()
    {
      string[][] items = [["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]];
      string ruleKey = "color";
      string ruleValue = "silver";
      var countItems = new CountItemsMatchingRule();
      var result = countItems.run(items, ruleKey, ruleValue);
      var expected = 1;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      string[][] items = [["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]];
      string ruleKey = "type";
      string ruleValue = "phone";
      var countItems = new CountItemsMatchingRule();
      var result = countItems.run(items, ruleKey, ruleValue);
      var expected = 2;
      Assert.AreEqual(expected, result);
    }
  }
}