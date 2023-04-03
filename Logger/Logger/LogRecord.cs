using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LogRecord
    {
        public DateTime Date { get; }
        public LogType Type { get; init; }
        public string Message { get; init; }

        public LogRecord()
        {
            Date = DateTime.Now;
        }
    }

    
}
