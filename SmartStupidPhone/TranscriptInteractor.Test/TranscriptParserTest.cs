using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmartStupidPhone.Core;
using TranscriptInteractor;
using Messages;

namespace TranscriptInteractor.Test
{        
    [TestClass]
    public class TranscriptParserTest
    {
        [TestMethod]
        public void ParseTranscriptToCalendar_Basic_Success()
        {
            var expectedDateResult = new DateTime(2013,4,24,15,18,0);
            string stringToBeInputtedIntoDateParser = "201304241518";                
            var dateParserMock = new Mock<IDateParser>();
            dateParserMock.Setup(dp => dp.GetDateTimeFromString(stringToBeInputtedIntoDateParser))
                .Returns(expectedDateResult);

            var transcriptParser = new TranscriptParser(dateParserMock.Object);
                       
            StringBuilder transcript = new StringBuilder();            
            //doesn't really matter what this date/time value is due to mocking
            transcript.AppendLine(stringToBeInputtedIntoDateParser);                 
            string eventTitle = "test title";
            transcript.AppendLine(eventTitle);
            
            CalendarAddMessage calendarAddMessage = 
                transcriptParser.ParseTranscriptToCalendar(transcript.ToString());

            Assert.AreEqual(expectedDateResult, calendarAddMessage.DateTime);
            Assert.AreEqual(eventTitle, calendarAddMessage.Title);
        }

        [TestMethod]
        public void ParseTranscriptToCalendar_LessThanTwoLines_Null()
        {
            var expectedDateResult = DateTime.Now;
            var dateParserMock = new Mock<IDateParser>();
            dateParserMock.Setup(dp => dp.GetDateTimeFromString(It.IsAny<string>()))
                .Returns(expectedDateResult);

            var transcriptParser = new TranscriptParser(dateParserMock.Object);
 
            StringBuilder transcript = new StringBuilder();            
            transcript.AppendLine("line1");

            CalendarAddMessage calendarAddMessage =
                transcriptParser.ParseTranscriptToCalendar(transcript.ToString());

            Assert.AreEqual(null, calendarAddMessage);
        }

        [TestMethod]
        public void ParseTranscriptToCalendar_DateTimeNotFound_Null()
        {
            var dateParserMock = new Mock<IDateParser>();
            dateParserMock.Setup(dp => dp.GetDateTimeFromString(It.IsAny<string>()))
                .Returns(new DateTime?());

            var transcriptParser = new TranscriptParser(dateParserMock.Object);


            StringBuilder transcript = new StringBuilder();
            //doesn't really matter what this value is due to mocking
            transcript.AppendLine("");
            string eventTitle = "test title";
            transcript.AppendLine(eventTitle);

            CalendarAddMessage calendarAddMessage =
                transcriptParser.ParseTranscriptToCalendar(transcript.ToString());

            Assert.AreEqual(null, calendarAddMessage);
        }

        [TestMethod]
        public void ParseTranscriptToCalendar_TitleIsEmpty_Null()
        {
            var expectedDateResult = DateTime.Now;
            var dateParserMock = new Mock<IDateParser>();
            dateParserMock.Setup(dp => dp.GetDateTimeFromString(It.IsAny<string>()))
                .Returns(expectedDateResult);

            var transcriptParser = new TranscriptParser(dateParserMock.Object);

            StringBuilder transcript = new StringBuilder();
            
            //doesn't really matter what this datetime value is due to mocking
            transcript.AppendLine("201304241518");
            transcript.AppendLine(string.Empty);

            CalendarAddMessage calendarAddMessage =
                transcriptParser.ParseTranscriptToCalendar(transcript.ToString());

            Assert.AreEqual(null, calendarAddMessage);
        }
    }
}
