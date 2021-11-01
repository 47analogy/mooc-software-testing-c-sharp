using System;

namespace NumFinder
{
  class NumFinderMain
  {
    static void Main(string[] args)
    {
      NumFinder nf1 = new NumFinder();
      NumFinder nf2 = new NumFinder();

      nf1.find(new int[] { 4, 25, 7, 9 });
      nf2.find(new int[] { 4, 3, 2, 1 });

      Console.WriteLine("test data 1:");
      Console.WriteLine(nf1.getLargest());
      Console.WriteLine(nf1.getSmallest());
      Console.WriteLine("test data 2:");
      Console.WriteLine(nf2.getLargest());
      Console.WriteLine(nf2.getSmallest());
    }
  }
}
// bug if input is null or empty array 