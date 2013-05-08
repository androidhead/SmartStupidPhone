/* //first implementation 
        public DateTime? GetDateTimeFromString(string dateString)
        {
 
            public DateTime?
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
*/

/* //better implementation
       public DateTime? GetDateTimeFromString(string dateString)
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
*/
 