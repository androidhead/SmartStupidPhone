using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StupidSmartPhone.Core;
using TranscriptInteractor;
using Messages;

namespace TranscriptInteractor.Test
{        
    [TestClass]
    public class TranscriptParserTest
    {
        //first line should be taken care of by Core.DateParser
        //second line should be description            
        //anything afterwards should be ignored
        //if it fails, just returns null 
        [TestMethod]
        public void ParseTranscriptToCalendar_Basic_Success()
        {
            //note:  could have abstracted these tests a little more, but didn't for demonstration purposes          
            var expectedDateResult = DateTime.Now;            
            var dateParserMock = new Mock<IDateParser>();
            dateParserMock.Setup(dp => dp.GetDateTimeFromYyyymmddhhmiString(It.IsAny<string>()))
                .Returns(expectedDateResult);

            var transcriptParser = new TranscriptParser(dateParserMock.Object);
                       
            StringBuilder transcript = new StringBuilder();            
            //doesn't really matter what this value is due to mocking
            transcript.AppendLine("201304241518");                 
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
            dateParserMock.Setup(dp => dp.GetDateTimeFromYyyymmddhhmiString(It.IsAny<string>()))
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
            dateParserMock.Setup(dp => dp.GetDateTimeFromYyyymmddhhmiString(It.IsAny<string>()))
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
            dateParserMock.Setup(dp => dp.GetDateTimeFromYyyymmddhhmiString(It.IsAny<string>()))
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
