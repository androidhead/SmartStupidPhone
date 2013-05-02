using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using StupidSmartPhone.Core;

namespace TranscriptInteractor
{
    interface ITranscriptParser
    {
        CalendarAddMessage ParseTranscriptToCalendar(string transcript);
    }
}
