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
  public class LengthOfLastWordTests
  {
    [Test()]
    public void runTest1()
    {
      var lengthOfLastWord = new LengthOfLastWord();
      string input = "Hello World";
      int result = lengthOfLastWord.run(input);
      Assert.AreEqual(5, result);
    }

    [Test()]
    public void runTest2()
    {
      var lengthOfLastWord = new LengthOfLastWord();
      string input = "   fly me   to   the moon  ";
      int result = lengthOfLastWord.run(input);
      Assert.AreEqual(4, result);
    }

    [Test()]
    public void runTest3()
    {
      var lengthOfLastWord = new LengthOfLastWord();
      string input = "luffy is still joyboy";
      int result = lengthOfLastWord.run(input);
      Assert.AreEqual(6, result);
    }

    [Test()]
    public void runTest4()
    {
      var lengthOfLastWord = new LengthOfLastWord();
      string input = "a ";
      int result = lengthOfLastWord.run(input);
      Assert.AreEqual(1, result);
    }

    [Test()]
    public void runTest5()
    {
      var lengthOfLastWord = new LengthOfLastWord();
      string input = "day";
      int result = lengthOfLastWord.run(input);
      Assert.AreEqual(3, result);
    }
  }
}