using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Log
    {
        public string logger, logPage, logMessage;
        public DateTime logDate;

        public Log(string logPage)
        {
            this.logPage = logPage;
        }
    }
}