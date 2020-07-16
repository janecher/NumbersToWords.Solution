using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ConversionTests
  {
    [TestMethod]
    public void NumberToStringConversion_ConvertNumberToWord_TwoHundredThirtyFive()
    {
      int number = 235;
      Assert.AreEqual("two hundred thirty five", Conversion.NumberToStringConversion(number));
    }

    [TestMethod]
    public void NumberToStringConversion_ConvertNumberToWord_OneHundredEvelen()
    {
      int number = 111;
      Assert.AreEqual("one hundred eleven", Conversion.NumberToStringConversion(number));
    }

    [TestMethod]
    public void NumberToStringConversion_ConvertNumberToWord_OneThousandTwo()
    {
      int number = 1002;
      Assert.AreEqual("one thousand two", Conversion.NumberToStringConversion(number));
    }
  }
}