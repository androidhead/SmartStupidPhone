using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidSmartPhone.Core
{
    public class DateParser : IDateParser
    {
        public DateTime? GetDateTimeFromString(string dateString)
        {
            if (dateString.Contains("/"))
            {
                return GetDateTimeFromSlashFormat(dateString);
            }
            else
            {
                return GetDateTimeFromYYYYMMDDDDHHMM(dateString);
            }            
        }

        int? ParseIntFromString(string s, int start, int length)
        {
            int output = 0;
            if (!int.TryParse(s.Substring(start, length), out output))
            {
                return null;
            }
            else
            {
                return output;
            }
        }

        private DateTime? GetDateTimeFromYYYYMMDDDDHHMM(string dateString)
        {
            if (dateString.Length < 12)
            {
                return null;
            }

            int? year = ParseIntFromString(dateString, 0, 4);
            int? month = ParseIntFromString(dateString, 4, 2);
            int? day = ParseIntFromString(dateString, 6, 2);
            int? hour = ParseIntFromString(dateString, 8, 2);
            int? minute = ParseIntFromString(dateString, 10, 2);

            DateTime? parsedDateTime = null;
            if (year.HasValue && month.HasValue && day.HasValue && hour.HasValue && minute.HasValue)
            {
                try
                {
                    parsedDateTime = new DateTime(year.Value, month.Value, day.Value, hour.Value, minute.Value, 0, 0);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return null;
                }
            }

            return parsedDateTime;
        }

        private DateTime? GetDateTimeFromSlashFormat(string dateString)
        {
            //format "xm/xd xh:mm" where x is not padded (only taken up if necessary)            
            //some initial checks (slash assumed; check for : and stuff on each side of slash, colon)
            string monthString = dateString.Split(' ')[0].Split('/')[0].Trim();
            string dayString = dateString.Split(' ')[0].Split('/')[1].Trim();
            string hourString = dateString.Split(' ')[1].Split(':')[0].Trim();
            string minuteString = dateString.Split(' ')[1].Split(':')[1].Trim();

            int? month = ParseIntFromString(monthString, 0, monthString.Length);
            int? day = ParseIntFromString(dayString, 0, dayString.Length);
            int? hour = ParseIntFromString(hourString, 0, hourString.Length);
            int? minute = ParseIntFromString(minuteString, 0, minuteString.Length);

            DateTime? parsedDateTime = null;
            if (month.HasValue && day.HasValue && hour.HasValue && minute.HasValue)
            {
                try
                {
                    parsedDateTime = new DateTime(DateTime.Now.Year, month.Value, day.Value, hour.Value, minute.Value, 0, 0);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return null;
                }
            }

            return parsedDateTime;
        }


    }      
}
