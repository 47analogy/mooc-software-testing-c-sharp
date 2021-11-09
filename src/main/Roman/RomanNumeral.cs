using System;
using System.Collections.Generic; //
using System.Linq;

namespace Roman
{

  public class RomanNumeralConverter
  {
    private static Dictionary<char, int> RomanNumMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int convert(string romanNumeral)
    {
      int convertedRoman = 0;
      for (int i = 0; i < romanNumeral.Length; i++)
      {
        if (i + 1 < romanNumeral.Length && RomanNumMap[romanNumeral[i]] < RomanNumMap[romanNumeral[i + 1]])
        {
          convertedRoman -= RomanNumMap[romanNumeral[i]];
        }
        else
        {
          convertedRoman += RomanNumMap[romanNumeral[i]];
        }
      }
      return convertedRoman;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      RomanNumeralConverter rn = new RomanNumeralConverter();
      Console.WriteLine(rn.convert("IL"));

    }
  }
}

