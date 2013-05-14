using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStupidPhone.Core
{
    public class DateParser : IDateParser
    {
       public DateTime? GetDateTimeFromString(string dateString)
       {
           if (dateString == null)
           {
               return null;
           }
           
            if(dateString.Length < 12)
            {
                return null;
            }

            int year = 0;
            if (!int.TryParse(dateString.Substring(0,4), out year))
            {
                return null;
            }

            int month = 0;
            if (!int.TryParse(dateString.Substring(4, 2), out month))
            {
                return null;
            }

            int day = 0;
            if (!int.TryParse(dateString.Substring(6, 2), out day))
            {
                return null;
            }

            int hour = 0;
            if (!int.TryParse(dateString.Substring(8, 2), out hour))
            {
                return null;
            }

            int minute = 0;
            if(!int.TryParse(dateString.Substring(10,2), out minute))
            {
                return null;
            }

            DateTime parsedDateTime;

            //todo: DEMONSTRATE: defect-finding: get rid of this try/catch, and see one of the tests fail
            try
            {
                parsedDateTime = new DateTime(year, month, day, hour, minute, 0, 0);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                return null;
            }

            return parsedDateTime;     
        }
    }      
}
