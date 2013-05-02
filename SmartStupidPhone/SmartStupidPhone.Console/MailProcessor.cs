using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleInteractor;
using TranscriptInteractor;
using Messages;

namespace SmartStupidPhone.Console
{
    internal class MailProcessor
    {
        #region InjectionProperties
        readonly ITranscriptParser _transcriptParser;
        ITranscriptParser TranscriptParser { get { return _transcriptParser; } }
        readonly IGmailReader _gmailReader;
        IGmailReader GmailReader { get { return _gmailReader; } }
        readonly IGcalendarWriter _gcalendarWriter;
        IGcalendarWriter GCalendarWriter { get { return _gcalendarWriter; } }
        #endregion

        public MailProcessor(ITranscriptParser transcriptParser, IGmailReader gmailReader, IGcalendarWriter gcalendarWriter)
        {
            _transcriptParser = transcriptParser;
            _gmailReader = gmailReader;
            _gcalendarWriter = gcalendarWriter;
        }
                
        public void Process()
        {
            //gets mail to process
            string transcript = _gmailReader.GetEarliestUnreadTranscript();
            //gets calendar entry from mail
            CalendarAddMessage calendarAddMessage = _transcriptParser.ParseTranscriptToCalendar(transcript);
            //sends to calendar
            _gcalendarWriter.WriteToGcalendar(calendarAddMessage);
        }    
    }
}
