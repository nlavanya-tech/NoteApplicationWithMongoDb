using Microsoft.EntityFrameworkCore;
using NoteApplication.Entities;
using System;

namespace NoteApplication.Database
{
    public class InMemoryDb : DbContext
    {
        //creating inmemory db context
        public InMemoryDb(DbContextOptions<InMemoryDb> options) : base(options)
        {

        }
      // creating inmemory collection property
        public DbSet<Notes> notes { get; set; }
    }
}
