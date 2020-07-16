using System;
using NumbersToWords;

class Program
{
  static void Main()
  {
    Console.WriteLine("Input the number to conversion: ");
    string userInput = Console.ReadLine();
    int number;
    if(int.TryParse(userInput, out number))
    {
      Console.WriteLine("Your number in words is: ");
      if(number < 0)
      {
        Console.WriteLine("negative "+Conversion.NumberToStringConversion(number));
      }
      else
      {
        Console.WriteLine(Conversion.NumberToStringConversion(number));
      }
    }
    else
    {
      Console.WriteLine("Incorrect input, only integers numbers");
    }
    Main();
  }
}