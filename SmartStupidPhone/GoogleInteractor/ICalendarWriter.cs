using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace ExternalInteractor
{
    public interface ICalendarWriter
    {
        bool WriteToGcalendar(CalendarAddMessage calendarAddMessage);
    }
}
