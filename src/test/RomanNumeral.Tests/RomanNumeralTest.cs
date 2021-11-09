using System;
using Xunit;
using Roman;

namespace RomanNumeral.Tests
{
  public class RomanNumeralTests
  {
    [Fact]
    public void singleNumber()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("I");
      Assert.Equal(1, result);
    }

    [Fact]
    public void manyDigitNumber()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("VIII");
      Assert.Equal(8, result);
    }

    [Fact]
    public void numberWithSubtraction()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("IV");
      Assert.Equal(4, result);
    }

    [Fact]
    public void invalidNumber() // should break
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("VIIIII");
      Assert.Equal(10, result);
    }

  }
}
