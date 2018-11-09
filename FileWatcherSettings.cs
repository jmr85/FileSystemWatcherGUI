using System.Collections.Specialized;
using System.Configuration;

namespace FileSystemWatcherComponent
{
    sealed class FileWatcherSettings : ApplicationSettingsBase
    {
        [UserScopedSettingAttribute()] 
        [DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>C:\juanidfdfdfdf</string>
  <string>juan</string>
  <string>pedro</string>
</ArrayOfString>")]
        public StringCollection Path
        {
            get { return (StringCollection)this["Path"]; }
            set { this["Path"] = value; }
        }
        
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>*.apk</string>
  <string>*.ipa</string>
  <string>*.zip</string>
  <string>*.txt</string>
</ArrayOfString>")]
        public StringCollection File
        {
            get { return (StringCollection)(this["File"]); }
            set { this["File"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool Subdirectory 
        {
            get { return (bool)this["Subdirectory"]; }
            set { this["Subdirectory"] = value; }
        }
    }
}
