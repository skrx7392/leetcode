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
  public class BadSensorTests
  {
    [Test()]
    public void runTest1()
    {
      int[] sensor1 = new int[] { 2, 3, 4, 5 };
      int[] sensor2 = new int[] { 2, 1, 3, 4 };
      var badSensor = new BadSensor();
      int result = badSensor.run(sensor1, sensor2);
      int expected = 2;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest2()
    {
      int[] sensor1 = new int[] { 2, 3, 2, 2, 3, 2 };
      int[] sensor2 = new int[] { 2, 3, 2, 3, 2, 7 };
      var badSensor = new BadSensor();
      int result = badSensor.run(sensor1, sensor2);
      int expected = 1;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest3()
    {
      int[] sensor1 = new int[] { 2, 2, 2, 2, 2 };
      int[] sensor2 = new int[] { 2, 2, 2, 2, 5 };
      var badSensor = new BadSensor();
      int result = badSensor.run(sensor1, sensor2);
      int expected = -1;
      Assert.AreEqual(expected, result);
    }

    [Test()]
    public void runTest4()
    {
      int[] sensor1 = new int[] { 2, 8, 5, 1, 10, 5, 9, 9, 3, 5 };
      int[] sensor2 = new int[] { 2, 8, 5, 1, 10, 5, 9, 9, 3, 5 };
      var badSensor = new BadSensor();
      int result = badSensor.run(sensor1, sensor2);
      int expected = -1;
      Assert.AreEqual(expected, result);
    }
  }
}