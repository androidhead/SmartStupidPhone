/*  //first set of tests
        
        //note: add test on-the-fly
 
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
*/

/*  //second set of tests
        [TestMethod]
        public void GetDateFromString_Basic_Success()
        {
            string input = "201305030101";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(input);

            Assert.AreEqual(new DateTime(2013, 5, 3, 1, 1, 0), output.Value);
        }

        [TestMethod]
        public void GetDateFromString_MinDateYYYYMMDDHHMM_Success()
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
        public void GetDateFromString_MaxDateYYYYMMDDHHMM_Success()
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
        public void GetDateFromString_RandomDateYYYYMMDDHHMM_Success()
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
        public void GetDateFromString_SlightlyInvalidDateYYYYMMDDHHMM_Null()
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

        [TestMethod]
        public void GetDateFromString_NullInput_Null()
        {
            string input = null;

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(input);

            Assert.IsNull(output);
        }
      
        [TestMethod]
        public void GetDateFromString_MinDateSlashFormat_Success()
        {
            var inputDateValue = DateTime.MinValue;

            string dateParserInput = String.Concat(                
                inputDateValue.Month,
                "/",
                inputDateValue.Day,
                " ",
                inputDateValue.Hour,
                ":",
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.AreEqual(DateTime.Now.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_MaxDateSlashFormat_Success()
        {
            var inputDateValue = DateTime.Now;

            string dateParserInput = String.Concat(
                inputDateValue.Month,
                "/",
                inputDateValue.Day,
                " ",
                inputDateValue.Hour,
                ":",
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            Assert.AreEqual(DateTime.Now.Year, inputDateValue.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_RandomDateSlashFormat_Success()
        {
            var inputDateValue = DateTime.MaxValue;

            string dateParserInput = String.Concat(
                inputDateValue.Month,
                "/",
                inputDateValue.Day,
                " ",
                inputDateValue.Hour,
                ":", //adb: good place for a purposeful mistake
                inputDateValue.Minute.ToString().PadLeft(2, '0'));

            var dateParser = new DateParser();
            
            DateTime? output = dateParser.GetDateTimeFromString(dateParserInput);

            //purposeful mistake
            Assert.AreEqual(DateTime.Now.Year, output.Value.Year);
            Assert.AreEqual(inputDateValue.Month, output.Value.Month);
            Assert.AreEqual(inputDateValue.Day, output.Value.Day);
            Assert.AreEqual(inputDateValue.Minute, output.Value.Minute);
            Assert.AreEqual(inputDateValue.Hour, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_SpecifiedSlashFormat_Success()
        {
            string inputDateString = "4/15 10:01";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(inputDateString);

            Assert.AreEqual(DateTime.Now.Year, output.Value.Year);
            Assert.AreEqual(4, output.Value.Month);
            Assert.AreEqual(15, output.Value.Day);
            Assert.AreEqual(1, output.Value.Minute);
            Assert.AreEqual(10, output.Value.Hour);
        }

        [TestMethod]
        public void GetDateFromString_EmptySlashFormat_Null()
        {
            string inputDateString = "/ :";

            var dateParser = new DateParser();
            DateTime? output = dateParser.GetDateTimeFromString(inputDateString);

            Assert.AreEqual(null, output);
        }
*/