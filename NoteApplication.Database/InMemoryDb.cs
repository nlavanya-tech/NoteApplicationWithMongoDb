using Microsoft.EntityFrameworkCore;
using NoteApplication.Entities;
using System;

namespace NoteApplication.Database
{
    public class InMemoryDb : DbContext
    {
        public InMemoryDb(DbContextOptions<InMemoryDb> options) : base(options)
        {

        }

        public DbSet<Notes> notes { get; set; }
    }
}
