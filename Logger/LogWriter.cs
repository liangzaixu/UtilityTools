using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class LogWriter
    {
        public static Core.ILog Debug()
        {
            return Core.Factory.GetLogger("Debug", 3);
        }
        public static Core.ILog Debug(string logInfo)
        {
            Core.ILog logger = Debug();
            logger.Write(logInfo);
            return logger;
        }
        public static Core.ILog Debug(string format, params object[] args)
        {
            Core.ILog logger = Debug();
            logger.WriteFormat(format, args);
            return logger;
        }
        public static Core.ILog Info()
        {
            return Core.Factory.GetLogger("Info", 60);
        }
        public static Core.ILog Info(string logInfo)
        {
            Core.ILog logger = Info();
            logger.Write(logInfo);
            return logger;
        }
        public static Core.ILog Info(string format, params object[] args)
        {
            Core.ILog logger = Info();
            logger.WriteFormat(format, args);
            return logger;
        }
        public static Core.ILog Error()
        {
            return Core.Factory.GetLogger("Error", 60);
        }
        public static Core.ILog Error(string logInfo)
        {
            Core.ILog logger = Error();
            logger.Write(logInfo);
            return logger;
        }
        public static Core.ILog Error(string format, params object[] args)
        {
            Core.ILog logger = Error();
            logger.WriteFormat(format, args);
            return logger;
        }
        public static Core.ILog Fatal()
        {
            return Core.Factory.GetLogger("Fatal", 60);
        }
        public static Core.ILog Fatal(string logInfo)
        {
            Core.ILog logger = Fatal();
            logger.Write(logInfo);
            return logger;
        }
        public static Core.ILog Fatal(string format, params object[] args)
        {
            Core.ILog logger = Fatal();
            logger.WriteFormat(format, args);
            return logger;
        }
    }
}
