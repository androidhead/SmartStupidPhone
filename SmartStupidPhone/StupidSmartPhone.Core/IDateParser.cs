﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidSmartPhone.Core
{
    public interface IDateParser
    {
        DateTime? GetDateFromYyyymmddhhmiString(string s);
    }
}