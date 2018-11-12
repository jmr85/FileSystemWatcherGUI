using LiteDB;
using System;
using System.Configuration;
using System.IO;

namespace FileSystemWatcherComponent.Data
{
    class FilePathDAO
    {
        //var connectionString = ConfigurationManager.ConnectionStrings["LiteDB"].ConnectionString;

        using(var db = new LiteDatabase(@"C:\database.db"))
        {
            //DateTime dateTime = new DateTime();
            // simple access to Insert/Update/Upsert/Delete
            db.Insert(new FilePathDTO { Path = "Table"});
       
        }
    }
}
