using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using SmartStupidPhone.Core;

namespace TranscriptInteractor
{
    public class TranscriptParser : ITranscriptParser
    {
        #region InjectionProperties
        readonly IDateParser _dateParser;
        IDateParser DateParser { get { return _dateParser; } }
        #endregion
        public TranscriptParser(IDateParser dateParser)
        {
            _dateParser = dateParser;
        }

        /// <summary>
        /// If invalid, returns null
        /// expects 2 or more lines
        /// first represents date
        /// second represents title
        /// if problem, return null
        /// </summary>
        /// <param name="transcript"></param>
        /// <returns></returns>
        public CalendarAddMessage ParseTranscriptToCalendar(string transcript)
        {
            var calendarAddMessage = new CalendarAddMessage();

            string[] lines = transcript.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);    
            if (lines.Count() < 2)
            {
                return null;
            }

            DateTime? parsedDateTime = DateParser.GetDateTimeFromString(lines[0]);

            if (parsedDateTime == null)
            {
                return null;
            }
            else
            {
                calendarAddMessage.DateTime = parsedDateTime.Value;
            }

            calendarAddMessage.Title = lines[1];

            return calendarAddMessage;
        }        
    }
}
