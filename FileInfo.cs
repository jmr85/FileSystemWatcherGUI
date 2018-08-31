using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystemWatcherComponent
{
    class FileInfoJMR
    {
        string fullPath;
        string changeType;
        DateTime dTime;

        public FileInfoJMR()
        {

        }

        public FileInfoJMR(string fullPath, string changeType, DateTime dTime)
        {
            this.fullPath = fullPath;
            this.changeType = changeType;
            this.dTime = dTime;
        }

        public string FullPath { get => fullPath; set => fullPath = value; }
        public string ChangeType { get => changeType; set => changeType = value; }
        public DateTime DTime { get => dTime; set => dTime = value; }
    }
}
