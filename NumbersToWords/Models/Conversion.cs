using System;
using System.Collections.Generic;

namespace NumbersToWords
{
  public class Conversion
  {
    private static Dictionary<int, string> _ones = new Dictionary<int, string>(){ {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
    private static Dictionary<int, string> _teens = new Dictionary<int, string>(){ {0, "ten"}, {1, "eleven"}, {2, "twelve"}, {3, "thirteen"}, {4, "fourteen"}, {5, "fifteen"}, {6, "sixteen"}, {7, "seventeen"}, {8, "eighteen"}, {9, "nineteen"}};
    private static Dictionary<int, string> _tens = new Dictionary<int, string>(){ {2, "twenty"}, {3, "thirty"}, {4, "fourty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"}};
    private static Dictionary<int, string> _placeValues = new Dictionary<int, string>(){ {0, "hundred"}, {1, "thousand"}, {2, "million"}, {3, "billion"}, {4, "trillion"}};

    public static List<List<int>> NumberToListsOfListOfThreeDigits(int numberToConvert)
    {
      int number = Math.Abs(numberToConvert);
      List<List<int>> listOfDigits = new List<List<int>>();
      while(number > 0)
      {
        int count = 0;
        List<int> listIfThreeDigits = new List<int>();
        while(count < 3)
        {
          listIfThreeDigits.Add(number%10);
          number /=10;
          count++;
        }
        listIfThreeDigits.Reverse();
        listOfDigits.Add(listIfThreeDigits);
      }
      return listOfDigits;
    }

    public static string ThreeDigitConversion(List<int> digits)
    {
      string result = "";
      if(digits[0] != 0)
      {
        result += _ones[digits[0]] + " " + _placeValues[0];
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

    public static string NumberToStringConversion(int number)
    {
      if(number == 0)
      {
        return "zero";
      }
      string result = "";
      List<List<int>> listOfListsOfDigits = NumberToListsOfListOfThreeDigits(number);
      int index = listOfListsOfDigits.Count - 1;     
      for(int i = index; i > 0; i--)
      {
        result += ThreeDigitConversion(listOfListsOfDigits[index]) + " " + _placeValues[i] + " ";
      }
      result += ThreeDigitConversion(listOfListsOfDigits[0]);
      return result.Trim();
    }
  }
}