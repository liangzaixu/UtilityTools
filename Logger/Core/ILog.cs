using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core
{
    public interface ILog
    {
        void Write(string logInfo);
        void WriteFormat(string format, params object[] args);
        void SaveLogToFile();
        void ClearLogFile();
    }
}

