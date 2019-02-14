﻿using LiteDB;
using System;
using System.Configuration;
using System.IO;

namespace FileSystemWatcherComponent.Data
{
    class FilePathDAO
    {
        //var connectionString = ConfigurationManager.ConnectionStrings["LiteDB"].ConnectionString;
         using(var db = new LiteDatabase(@"C:\Temp\MyData.db"))
        {
            //DateTime dateTime = new DateTime();
            // simple access to Insert/Update/Upsert/Delete
            //db.Insert(new FilePathDTO { Path = "Table"});

            // Get customer collection
            var col = db.GetCollection<FilePathDTO>("customers");

            // Create your new customer instance
            var filePathDTO = new FilePathDTO
            {
                Path = "John Doe"
            };
	
            // Insert new customer document (Id will be auto-incremented)
            col.Insert(filePathDTO);    
       
        }
    }
}
