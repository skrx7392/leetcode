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
  public class ConsecutiveCharactersTests
  {
    [Test()]
    public void runTest1()
    {
      string s = "leetcode";
      var consChar = new ConsecutiveCharacters();
      var result = consChar.run(s);
      var expected = 2;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      string s = "abbcccddddeeeeedcba";
      var consChar = new ConsecutiveCharacters();
      var result = consChar.run(s);
      var expected = 5;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      string s = "tourist";
      var consChar = new ConsecutiveCharacters();
      var result = consChar.run(s);
      var expected = 1;
      Assert.AreEqual(expected, result);
    }
  }
}