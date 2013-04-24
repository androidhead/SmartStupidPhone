using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using StupidSmartPhone.Core;

namespace TranscriptInteractor
{
    public class TranscriptParser
    {
        #region InjectionProperties
        readonly IDateParser _dateParser;
        IDateParser DateParser { get { return _dateParser; } }
        #endregion
        public TranscriptParser(IDateParser dateParser)
        {
            _dateParser = dateParser;
        }
        public CalendarAddMessage ParseTranscriptToCalendar(string transcript)
        {
            //expects 2 lines
            //first represents date
            //second represents title
            //if problem, return null
            throw new NotImplementedException();
        }
    }
}
