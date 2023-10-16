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
  public class SortSentenceTests
  {
    [Test()]
    public void runTest1()
    {
      string s = "is2 sentence4 This1 a3";
      var sortSentence = new SortSentence();
      var result = sortSentence.run(s);
      var expected = "This is a sentence";
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      string s = "Myself2 Me1 I4 and3";
      var sortSentence = new SortSentence();
      var result = sortSentence.run(s);
      var expected = "Me Myself and I";
      Assert.AreEqual(expected, result);
    }
  }
}