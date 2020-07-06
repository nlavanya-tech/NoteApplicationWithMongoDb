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
        private readonly IMongoDatabase _db;
        public MongoDbContext(IOptions<MongoDbSetting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<Notes> notes => _db.GetCollection<Notes>("notes");
    }
}
