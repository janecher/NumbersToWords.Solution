using System;
using System.Collections.Generic;

namespace NumbersToWords
{
  public class Conversion
  {
    private static Dictionary<int, string> _ones = new Dictionary<int, string>(){ {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
    private static Dictionary<int, string> _teens = new Dictionary<int, string>(){ {0, "ten"}, {1, "eleven"}, {2, "twelve"}, {3, "thirteen"}, {4, "fourteen"}, {5, "fifteen"}, {6, "sixteen"}, {7, "seventeen"}, {8, "eighteen"}, {9, "nineteen"}};
    private static Dictionary<int, string> _tens = new Dictionary<int, string>(){ {2, "twenty"}, {3, "thirty"}, {4, "fourty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"}};
    private static Dictionary<int, string> _placeValues = new Dictionary<int, string>(){ {1, "hundred"}, {2, "thousand"}, {3, "million"}, {4, "billion"}, {5, "trillion"}};

    public static List<int> NumberToListOfDigits(int number)
    {
      List<int> listOfDigits = new List<int>();
      while(number > 0)
      {
        listOfDigits.Add(number%10);
        number /=10;
      }
      listOfDigits.Reverse();
      return listOfDigits;
    }

    public static int NumberOfDigits(int number)
    {
      return NumberToListOfDigits(number).Count;
    }

    public static string ThreeDigitConversion(List<int> digits)
    {
      string result = "";
      if(digits[0] != 0)
      {
        result += _ones[digits[0]] + " " + _placeValues[1];
      }
      if(digits[1] != 0)
      {
        if(digits[1] == 1)
        {
          result += " " + _teens[digits[2]];
          return result;
        }
        else
        {
          result += " " + _tens[digits[1]];
        }
      }
      if(digits[2] != 0)
      {
        result += " " + _ones[digits[2]];
      }
      return result;
    }

  }
}