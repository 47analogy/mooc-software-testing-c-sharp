using System;
using Xunit;

// equivalence partitioning

namespace LeapYear.Tests
{
  public class LeapYearTest
  {
    [Fact]
    // divisible by 4, not divisible by 100 -> 2016, 2020
    public void leapYearsThatAreNonCenturialYears()
    {
      LeapYear ly = new LeapYear();
      bool result = ly.isLeapYear(2016);
      Assert.True(result == true);
    }
    [Fact]
    // divisible by 4, divisible by 100, divisible by 400 -> 2000
    public void leapCenturialYears()
    {
      LeapYear ly = new LeapYear();
      bool result = ly.isLeapYear(2000);
      Assert.True(result == true);
    }

    [Fact]
    // divisible by 4, divisible by 100, not divisible by 100 -> 1500, 1900
    public void nonLeapCenturialYears()
    {
      LeapYear ly = new LeapYear();
      bool result = ly.isLeapYear(1500);
      Assert.True(result == false);
    }

    [Fact]
    // not divisible by 4 -> 2015, 2017
    public void nonLeapYears()
    {
      LeapYear ly = new LeapYear();
      bool result = ly.isLeapYear(2017);
      Assert.True(result == false);
    }
  }
}
