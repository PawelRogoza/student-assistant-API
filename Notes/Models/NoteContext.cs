using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class NoteContext : DbContext
    {
        public NoteContext()
        {
        }

        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
