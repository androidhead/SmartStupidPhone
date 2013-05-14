using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStupidPhone.Core
{
    public interface IDateParser
    {
        DateTime? GetDateTimeFromString(string s);
    }
}
