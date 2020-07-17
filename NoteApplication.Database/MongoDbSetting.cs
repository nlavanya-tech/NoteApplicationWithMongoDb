using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApplication.DataLayer
{
    public class MongoDbSetting 
    {
        //mongo db connection properties 
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
