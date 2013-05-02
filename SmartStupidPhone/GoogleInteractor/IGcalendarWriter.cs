using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace GoogleInteractor
{
    public interface IGcalendarWriter
    {
        bool WriteToGcalendar(CalendarAddMessage calendarAddMessage);
    }
}
