using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StupidSmartPhone.Core;

namespace StupidSmartPhone.Core.Test
{
    [TestClass]
    public class DateParserTest
    {
        //handle any valid date (valid defined by DateTime object)
        //return null if dates are invalid        
        [TestMethod]
        public void GetDateTimeFromYyyymmddhhmiString_MinDate_Success()
        {
            var inputDateValue = DateTime.MinValue;

            string dateParserInput = String.Concat(
                inputDateValue.Year.ToString().PadLeft(4, '0'),
                inputDateValue.Month.ToString().PadLeft(2, '0'),
                inputDateValue.Day.ToString().PadLeft(2, '0'),
                inputDateValue.Hour.ToString().PadLeft(2, '0'),
                inputDateValue.Minute.ToString().PadLeft(2, '0'));
        
            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromYyyymmddhhmiString(dateParserInput);

            Assert.AreEqual(inputDateValue.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateTimeFromYyyymmddhhmiString_MaxDate_Success()
        {
            var inputDateValue = DateTime.MinValue;

            string dateParserInput = String.Concat(
                inputDateValue.Year.ToString().PadLeft(4, '0'),
                inputDateValue.Month.ToString().PadLeft(2, '0'),
                inputDateValue.Day.ToString().PadLeft(2, '0'),
                inputDateValue.Hour.ToString().PadLeft(2, '0'),
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromYyyymmddhhmiString(dateParserInput);

            Assert.AreEqual(inputDateValue.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateTimeFromYyyymmddhhmiString_RandomDate_Success()
        {
            var inputDateValue = DateTime.Now;

            string dateParserInput = String.Concat(
                inputDateValue.Year.ToString().PadLeft(4, '0'),
                inputDateValue.Month.ToString().PadLeft(2, '0'),
                inputDateValue.Day.ToString().PadLeft(2, '0'),
                inputDateValue.Hour.ToString().PadLeft(2, '0'),
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromYyyymmddhhmiString(dateParserInput);

            Assert.AreEqual(inputDateValue.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateTimeFromYyyymmddhhmiString_SlightlyInvalidDate_Null()
        {

            string dateParserInput = "200002301200";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromYyyymmddhhmiString(dateParserInput);

            Assert.IsFalse(output.HasValue);
        }

        [TestMethod]
        public void GetDateTimeFromYyyymmddhhmiString_EmptyInput_Null()
        {
            string dateParserInput = String.Empty;

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromYyyymmddhhmiString(dateParserInput);

            Assert.IsFalse(output.HasValue);
        }

        [TestMethod]
        public void GetDateTimeFromYyyymmddhhmiString_VeryInvalidDate_Null()
        {
            string dateParserInput = "this is not nearly a date";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromYyyymmddhhmiString(dateParserInput);

            Assert.IsFalse(output.HasValue);
        }
    }
}
