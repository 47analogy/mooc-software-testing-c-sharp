using System;

namespace ChocolateBags
{
  // Given a total, how many small bars can fit into a package when using big bars first?
  public class ChocolateBags
  {
    public int calculate(int small, int big, int total)
    {
      int maxBigBoxes = total / 5;
      int bigBoxesWeCanUse = maxBigBoxes < big ? maxBigBoxes : big;
      total -= (bigBoxesWeCanUse * 5);

      if (small < total)
        return -1;
      return total;

    }
  }
}


