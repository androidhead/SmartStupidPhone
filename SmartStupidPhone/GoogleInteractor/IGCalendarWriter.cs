using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleInteractor
{
    interface IGCalendarWriter
    {
        bool WriteToGCalendar(DateTime when, string Title);    
    }
}
