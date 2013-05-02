using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalInteractor
{
    public interface IMailReader
    {
        string GetEarliestUnreadTranscript();   
    }
}
