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
  public class CheckIfPangramTests
  {
    [Test()]
    public void runTest1()
    {
      string s = "thequickbrownfoxjumpsoverthelazydog";
      var checker = new CheckIfPangram();
      var result = checker.run(s);
      Assert.IsTrue(result);
    }

    [Test()]
    public void runTest2()
    {
      string s = "leetcode";
      var checker = new CheckIfPangram();
      var result = checker.run(s);
      Assert.IsFalse(result);
    }
  }
}