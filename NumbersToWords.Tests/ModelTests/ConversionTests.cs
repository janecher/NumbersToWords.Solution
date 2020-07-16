using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ConversionTests
  {
    [TestMethod]
    public void NumberOfDigits_CountNumberOfDigitsInTheNumber_IntegerNumber()
    {
      int number = 235;
      Assert.AreEqual(3, Conversion.NumberOfDigits(number));
    }

    [TestMethod]
    public void ThreeDigitConversion_CountNumberToWord_TwoHundredThirtyFive()
    {
      int number = 235;
      Assert.AreEqual("two hundred thirty five", Conversion.ThreeDigitConversion(Conversion.NumberToListOfDigits(number)));
    }

    [TestMethod]
    public void ThreeDigitConversion_CountNumberToWord_OneHundredEvelen()
    {
      int number = 111;
      Assert.AreEqual("one hundred eleven", Conversion.ThreeDigitConversion(Conversion.NumberToListOfDigits(number)));
    }
  }
}