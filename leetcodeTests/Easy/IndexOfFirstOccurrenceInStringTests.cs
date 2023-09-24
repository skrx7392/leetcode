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
  public class IndexOfFirstOccurrenceInStringTests
  {
    [Test()]
    public void StrStrTest1()
    {
      var sub = new IndexOfFirstOccurrenceInString();
      var haystack = "sadbutsad";
      var needle = "sad";
      var result = sub.StrStr(haystack, needle);
      Assert.AreEqual(0, result);
    }

    [Test()]
    public void StrStrTest2()
    {
      var sub = new IndexOfFirstOccurrenceInString();
      var haystack = "leetcode";
      var needle = "leeto";
      var result = sub.StrStr(haystack, needle);
      Assert.AreEqual(-1, result);
    }

    [Test()]
    public void StrStrTest3()
    {
      var sub = new IndexOfFirstOccurrenceInString();
      var haystack = "mississippi";
      var needle = "issip";
      var result = sub.StrStr(haystack, needle);
      Assert.AreEqual(4, result);
    }

    [Test()]
    public void StrStrTest4()
    {
      var sub = new IndexOfFirstOccurrenceInString();
      var haystack = "aaa";
      var needle = "aaaa";
      var result = sub.StrStr(haystack, needle);
      Assert.AreEqual(-1, result);
    }
  }
}