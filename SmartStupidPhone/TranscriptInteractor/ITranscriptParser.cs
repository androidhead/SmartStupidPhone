﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using SmartStupidPhone.Core;

namespace TranscriptInteractor
{
    public interface ITranscriptParser
    {
        CalendarAddMessage ParseTranscriptToCalendar(string transcript);
    }
}
