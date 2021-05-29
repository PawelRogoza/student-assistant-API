using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Repository
{
    public interface INotesRepository
    {
        IEnumerable<Note> GetAll();
        Note GetById(int id);
        void Add(Note note);
        void Update(Note note);
        void Delete(int id);
        void Save();
    }
}
