using System;
using Xunit;
using Roman;

namespace RomanNumeral.Tests
{
  public class RomanNumeralTests
  {
    public SetupBeforeEachTest()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
    }
    [Fact]
    public void singleNumber()
    {
      //RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("I");
      Assert.Equal(1, result);
    }

    [Fact]
    public void manyDigitNumber()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter(); // Arrange
      int result = roman.convert("VIII"); // Act
      Assert.Equal(8, result); // Assert
    }

    [Fact]
    public void numberWithSubtraction()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("IV");
      Assert.Equal(4, result);
    }

    [Fact]
    public void invalidNumber() // should fail
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("VIIIII");
      Assert.Equal(10, result);
    }

    [Fact]
    public void numberWithAndWithoutSubtractiveNotation()
    {
      RomanNumeralConverter roman = new RomanNumeralConverter();
      int result = roman.convert("XLIV");
      Assert.Equal(44, result);
    }

  }
}
