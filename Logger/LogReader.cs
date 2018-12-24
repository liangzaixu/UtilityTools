using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class LogReader
    {
        public static System.Collections.Generic.List<string> GetLogFilePreList()
        {
            return Core.Factory.GetLogFilePreList();
        }
        public static System.IO.FileInfo[] GetLogFiles(string logFilePre)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Core.Factory.logsDirPath);
            if (!dir.Exists)
            {
                return new System.IO.FileInfo[] { };
            }
            logFilePre = Core.Factory.GetLogFilePre(logFilePre);
            System.IO.FileInfo[] fis = dir.GetFiles(logFilePre + "*.log", System.IO.SearchOption.TopDirectoryOnly);
            if (fis == null)
            {
                fis = new System.IO.FileInfo[] { };
            }
            return fis;
        }
        public static Core.TextFileReader GetTextFileReader(System.IO.FileInfo logFileInfo)
        {
            Core.TextFileReader textFileReader = new Core.TextFileReader(logFileInfo.FullName);
            textFileReader.ReadBytes = 1024 * 1024 * 2;
            return textFileReader;
        }
    }
}
