using System;
using Xunit;

namespace ChocolateBags.Tests
{
  public class ChocolateBagsTests
  {
    [Fact]
    //total is higher than the amount of small and big bars (i.e. sm = 1, big = 1, tot = 10)
    public void totalIsBiggerThanAmountOfBars()
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(1, 1, 10);
      Assert.Equal(-1, result);
    }

    [Fact]
    // only big bars (i.e. sm = 5, big = 3, tot = 10) -> return 0
    public void onlyBigBars()
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(5, 3, 10);
      Assert.Equal(0, result);
    }

    [Fact]
    // big and small bars (i.e. sm = 5, big = 3, tot = 17) -> return 2
    public void bigAndSmallBars()
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(5, 3, 17);
      Assert.Equal(2, result);
    }

    [Fact]
    // only small bars (ie. sm = 4, big = 2, total = 3) -> returns 3
    public void onlySmallBars()
    {
      ChocolateBags cb = new ChocolateBags();
      int result = cb.calculate(4, 2, 3);
      Assert.Equal(3, result);
    }
  }
}




