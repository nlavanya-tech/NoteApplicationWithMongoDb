using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NoteApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApplication.DataLayer.Context
{
   public class MongoDbContext : IMongoDbContext
    {
        //creation mongo db context 
        private readonly IMongoDatabase _db;

        //get mongodb connection string values options from app settings
        public MongoDbContext(IOptions<MongoDbSetting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
      //  get notes collection from mongodb
        public IMongoCollection<Notes> notes => _db.GetCollection<Notes>("notes");
    }
}
