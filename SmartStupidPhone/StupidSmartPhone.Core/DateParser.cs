using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidSmartPhone.Core
{
    public class DateParser : IDateParser
    {
        /// <summary>
        /// if it fails, return null
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public DateTime? GetDateTimeFromString(string dateString)
        {
            throw new NotImplementedException();
        }
    }
}
