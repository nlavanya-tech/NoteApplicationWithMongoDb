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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
          //  var notes = this.DbContext.notes.ToList();
            var newnotes = await _context.notes.Find(note => true).ToListAsync();
            return newnotes;
        }
        public async Task<Notes> CreateAsync(Notes notes)
        {
           // this.DbContext.Add(notes);
           // this.DbContext.SaveChanges();
            await _context.notes.InsertOneAsync(notes);
            return notes;
        }
        public async Task<Notes> UpdateAsync(Notes note)
        {
            //var notes = this.DbContext.notes.FirstOrDefault(e => e.Id == note.Id);
            //if (notes != null)
            //{
            //    notes.Id = note.Id;
            //    notes.Title = note.Title;
            //    notes.Author = note.Author;
            //    notes.Description = note.Description;
            //    notes.Status = note.Status;
            //    this.DbContext.SaveChanges();
            //}
            //else
            //{
            //    note = null;
            //}
            return note;
        }
        public async Task<Notes> DeleteAsync(Notes notes)
        {
            //var note = this.DbContext.notes.FirstOrDefault(e => e.Id == notes.Id);
            //if (notes != null)
            //{
            //    this.DbContext.Remove(notes.Id);
            //    this.DbContext.SaveChanges();
            //    return notes;
            //}
            //else
            //{
            //    return null;
            //}
            return notes;
        }
    }
}
