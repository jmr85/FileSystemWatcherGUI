using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystemWatcherComponent
{
    class FileInfoJMR
    {
        public string FullPath { get; set; }
        public string ChangeType { get; set; }
        public DateTime DTime { get; set; }
        

        public FileInfoJMR()
        {

        }

        public FileInfoJMR(string fullPath, string changeType, DateTime dTime)
        {
            this.FullPath = fullPath;
            this.ChangeType = changeType;
            this.DTime = dTime;
        }

        //public string FullPath { get => fullPath; set => fullPath = value; }
        //public string ChangeType { get => changeType; set => changeType = value; }
        //public DateTime DTime { get => dTime; set => dTime = value; }
    }
}
