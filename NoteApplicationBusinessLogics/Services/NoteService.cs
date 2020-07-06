using NoteApplication.BusinessLogics.Interface;
using NoteApplication.BusinessLogics.Services.Repository;
using NoteApplication.Database;
using NoteApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApplication.BusinessLogics.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repositary;

        public NoteService(INoteRepository repositary)
        {
            _repositary = repositary;
        }

        //private InMemoryDb DbContext;
        //public NoteService(InMemoryDb DbContext)
        //{
        //    this.DbContext = DbContext;
        //}
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            var notes = await _repositary.ReadAsync();
           // var notes = this.DbContext.notes.ToList();
            return notes;
        }
        public async Task<Notes> CreateAsync(Notes notes)
        {
            await _repositary.CreateAsync(notes);
            //this.DbContext.Add(notes);
            //this.DbContext.SaveChanges();
            return notes;
        }
        public async Task<Notes> UpdateAsync(Notes notes)
        {
            var note = await _repositary.UpdateAsync(notes);
            
            return note;
        }
        public async Task<Notes> DeleteAsync(Notes notes)
        {
            var result = await _repositary.DeleteAsync(notes);
            return result;
        }
    }
}

