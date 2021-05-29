using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notes.Models;
using Notes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesRepository notesRepository;

        public NotesController(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }


        // GET all notes
        [HttpGet]
        public IEnumerable<Note> GetNotes()
        {
            return notesRepository.GetAll();
        }

        // GET note by ID
        [HttpGet("{id}")]
        public ActionResult<Note> GetNote(int id)
        {
            var Note = notesRepository.GetById(id);

            if (Note == null)
            {
                return NotFound();
            }

            return Note;
        }

        // POST note
        [HttpPost]
        public ActionResult<Note> PostNote(Note note)
        {
            notesRepository.Add(note);
            notesRepository.Save();

            return CreatedAtAction(nameof(GetNote), new { id = note.Id }, note);
        }

        // PUT note
        [HttpPut("{id}")]
        public ActionResult<Note> PutNote(int id, Note note)
        {
            if (id != note.Id)
            {
                return BadRequest();
            }

            notesRepository.Update(note);
            notesRepository.Save();

            return NoContent();
        }

        // DELETE note
        [HttpDelete("{id}")]
        public ActionResult<Note> DeleteNote(int id)
        {
            notesRepository.Delete(id);
            notesRepository.Save();

            return NoContent();
        }

    }
}
