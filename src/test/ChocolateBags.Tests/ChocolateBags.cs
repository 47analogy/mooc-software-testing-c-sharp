using System;
using Xunit;

namespace ChocolateBags.Tests
{
  public class ChocolateBagsTests
  {
    [Theory]
    [InlineData(1, 1, 5, 0)]
    [InlineData(1, 1, 6, 1)]
    [InlineData(1, 1, 7, -1)]
    [InlineData(1, 1, 8, -1)]
    //total is higher than the amount of small and big bars (i.e. sm = 1, big = 1, tot = 10)
    public void totalIsBiggerThanAmountOfBars(int small, int big, int total, int expected)
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(small, big, total);
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(4, 0, 10, -1)]
    [InlineData(4, 1, 10, -1)]
    [InlineData(5, 2, 10, 0)]
    [InlineData(5, 3, 10, 0)]
    // only big bars (i.e. sm = 5, big = 3, tot = 10) -> return 0
    public void onlyBigBars(int small, int big, int total, int expected)
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(small, big, total);
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 3, 17, -1)]
    [InlineData(1, 3, 17, -1)]
    [InlineData(2, 3, 17, 2)]
    [InlineData(3, 3, 17, 2)]
    [InlineData(0, 3, 12, -1)]
    [InlineData(1, 3, 12, -1)]
    [InlineData(2, 3, 12, 2)]
    [InlineData(3, 3, 12, 2)]
    // big and small bars (i.e. sm = 5, big = 3, tot = 17) -> return 2
    public void bigAndSmallBars(int small, int big, int total, int expected)
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(small, big, total);
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(4, 2, 3, 3)]
    [InlineData(3, 2, 3, 3)]
    [InlineData(2, 2, 3, -1)]
    [InlineData(1, 2, 3, -1)]
    // only small bars (ie. sm = 4, big = 2, total = 3) -> returns 3
    public void onlySmallBars(int small, int big, int total, int expected)
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(small, big, total);
      Assert.Equal(expected, result);
    }
  }
}




