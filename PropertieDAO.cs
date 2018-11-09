using FileSystemWatcherComponent.Properties;
using System.Collections.Specialized;

namespace FileSystemWatcherComponent
{
    class PropertieDAO
    {
       
        private PropertieDAO(){}

        public static void RemoveListFile(int index)
        {
            Settings.Default.file.RemoveAt(index);
       
        }
        public static int AddListFile(string value)
        {
            return Settings.Default.file.Add(value); 
        }

        public static object[] ListAllFile()
        {
           
            var list = new string[Settings.Default.file.Count];
            Settings.Default.file.CopyTo(list, 0);
            var arrayListFiles = new object[] { };
            arrayListFiles = list;

            return arrayListFiles;
        }

        public static int FileCount()
        {
            return Settings.Default.file.Count;
        }
    }
}
