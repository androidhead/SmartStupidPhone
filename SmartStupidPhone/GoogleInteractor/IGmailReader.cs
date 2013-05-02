using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleInteractor
{
    public interface IGmailReader
    {
        string GetEarliestUnreadTranscript();   
    }
}
