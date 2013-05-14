using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartStupidPhone.Core;

namespace SmartStupidPhone.Core.Test
{
    [TestClass]
    public class DateParserTest
    {
        [TestMethod]
        public void GetDateFromString_MinDate_Success()
        {
            var inputDateValue = DateTime.MinValue;

            string dateParserInput = String.Concat(
                inputDateValue.Year.ToString().PadLeft(4, '0'),
                inputDateValue.Month.ToString().PadLeft(2, '0'),
                inputDateValue.Day.ToString().PadLeft(2, '0'),
                inputDateValue.Hour.ToString().PadLeft(2, '0'),
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.AreEqual(inputDateValue.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_MaxDate_Success()
        {
            var inputDateValue = DateTime.MinValue;

            string dateParserInput = String.Concat(
                inputDateValue.Year.ToString().PadLeft(4, '0'),
                inputDateValue.Month.ToString().PadLeft(2, '0'),
                inputDateValue.Day.ToString().PadLeft(2, '0'),
                inputDateValue.Hour.ToString().PadLeft(2, '0'),
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.AreEqual(inputDateValue.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_NullInput_Null()
        {
            string input = null;

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(input);

            Assert.IsNull(output);
        }
      
        [TestMethod]
        public void GetDateFromString_RandomDate_Success()
        {
            var inputDateValue = DateTime.Now;

            string dateParserInput = String.Concat(
                inputDateValue.Year.ToString().PadLeft(4, '0'),
                inputDateValue.Month.ToString().PadLeft(2, '0'),
                inputDateValue.Day.ToString().PadLeft(2, '0'),
                inputDateValue.Hour.ToString().PadLeft(2, '0'),
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.AreEqual(inputDateValue.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_SlightlyInvalidDate_Null()
        {
            string dateParserInput = "200002301200";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.IsFalse(output.HasValue);
        }

        [TestMethod]
        public void GetDateFromString_EmptyInput_Null()
        {
            string dateParserInput = String.Empty;

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.IsFalse(output.HasValue);
        }

        [TestMethod]
        public void GetDateFromString_VeryInvalidDate_Null()
        {
            string dateParserInput = "this is not nearly a date";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.IsFalse(output.HasValue);
        }
    }
}
