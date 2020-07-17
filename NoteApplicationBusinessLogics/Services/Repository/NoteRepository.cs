using NoteApplication.Database;
using NoteApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NoteApplication.DataLayer;
using MongoDB.Driver;
using NoteApplication.DataLayer.Context;

namespace NoteApplication.BusinessLogics.Services.Repository
{
    public class NoteRepository : INoteRepository
    {

     //   private InMemoryDb DbContext;
        private readonly IMongoDbContext _context;
        public NoteRepository(IMongoDbContext context)
        {
            _context = context;
          //  this.DbContext = DbContext;
        }

       //To get All notes from Mongo DB
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            throw new NotImplementedException();
        }

        //Inserting new notes in MongoDB
        public async Task<Notes> CreateAsync(Notes notes)
        {
            throw new NotImplementedException();
        }

        //To Update perticular notes in MongoDB based on Notes Id
        public async Task<Notes> UpdateAsync(Notes note)
        {
            throw new NotImplementedException();
        }

        //To Delete Particular notes in mongodb based on Notes ID
        public async Task<Notes> DeleteAsync(Notes notes)
        {
            throw new NotImplementedException();
        }
    }
}
