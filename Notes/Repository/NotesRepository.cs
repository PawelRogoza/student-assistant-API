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
        private readonly NoteContext _context;

        public NotesRepository(NoteContext context)
        {
            this._context = context;
        }
        public void Add(Note note)
        {
            _context.Notes.Add(note);
        }

        public void Delete(int id)
        {
            var Note = _context.Notes.Find(id);
            _context.Notes.Remove(Note);
        }

        public Note GetById(int id)
        {
            var Note = _context.Notes.Find(id);
            return Note;

        }

        public IEnumerable<Note> GetAll()
        {
            return _context.Notes.ToList();
        }

        public void Update(Note note)
        {
            _context.Entry(note).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
