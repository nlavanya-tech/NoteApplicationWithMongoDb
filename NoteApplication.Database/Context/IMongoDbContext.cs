using MongoDB.Driver;
using NoteApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApplication.DataLayer.Context
{
    public interface IMongoDbContext
    {
        IMongoCollection<Notes> notes { get; }
    }
}
