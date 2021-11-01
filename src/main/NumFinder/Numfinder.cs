using System;

namespace NumFinder
{
  public class NumFinder
  {
    private int smallest = Int32.MaxValue;
    private int largest = Int32.MinValue;

    public void find(int[] nums)
    {
      foreach (int n in nums)
      {

        if (n < smallest)
          smallest = n;
        if (n > largest) // else if breaks program
          largest = n;

      }
    }

    public int getSmallest()
    {
      return smallest;
    }

    public int getLargest()
    {
      return largest;
    }
  }
}
