using Microsoft.EntityFrameworkCore;
using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Repository
{
    public class NotesRepository : INotesRepository
    {
        private readonly NoteContext _dbcontext;

        public NotesRepository(NoteContext context)
        {
            this._dbcontext = context;
        }
        public void Add(Note note)
        {
            _dbcontext.Notes.Add(note);
        }

        public void Delete(int id)
        {
            var Note = _dbcontext.Notes.Find(id);
            if (Note == null) return;

            _dbcontext.Notes.Remove(Note);
        }

        public Note GetById(int id)
        {
            var Note = _dbcontext.Notes.Find(id);
            return Note;

        }

        public IEnumerable<Note> GetAll()
        {
            return _dbcontext.Notes.ToList();
        }

        public void Update(Note note)
        {
            _dbcontext.Entry(note).State = EntityState.Modified;
        }
        public void Save()
        {
            _dbcontext.SaveChanges();
        }
    }
}
