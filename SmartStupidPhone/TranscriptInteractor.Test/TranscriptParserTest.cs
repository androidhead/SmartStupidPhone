using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StupidSmartPhone.Core;
using TranscriptInteractor;

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
            var dateParserMock = new Mock<IDateParser>();
            var expectedDateResult = DateTime.Now;
            dateParserMock.Setup(dp => dp.GetDateFromYyyymmddhhmiString(It.IsAny<string>()))
                .Returns(expectedDateResult);
            var transcriptParser = new TranscriptParser(dateParserMock.Object);

            StringBuilder transcript = new StringBuilder();
            transcript.AppendLine("ThisShouldBeSomeParseableDateTimeString");
            transcript.AppendLine("event title");
            
            transcriptParser.ParseTranscriptToCalendar(transcript.ToString());
        }

        [TestMethod]
        public void ParseTranscriptToCalendar_LessThanTwoLines_Null()
        {

        }

        [TestMethod]
        public void ParseTranscriptToCalendar_DateTimeNotFound_Null()
        {

        }

        [TestMethod]
        public void ParseTranscriptToCalendar_TitleIsEmpty_Null()
        {

        }
    }
}
