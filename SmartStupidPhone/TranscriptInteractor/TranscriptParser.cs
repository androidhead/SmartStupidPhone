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
        #region InjectionPropertiesAndMethods
        DateParser _dateParser;
        DateParser DateParser
        {
            get
            {
                if (_dateParser == null)
                {
                    _dateParser = new DateParser();
                }
                return _dateParser;
            }
        }
    
        public void InjectDateParser(DateParser dateParser)
        {
            _dateParser = dateParser;
        }
        #endregion

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
