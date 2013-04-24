using System;
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
