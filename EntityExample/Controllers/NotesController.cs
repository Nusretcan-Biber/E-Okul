using Businnes.Model_Services;
using Core.Check_List;
using Core.ExeptionControl;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityExample.Controllers
{
    public class NotesController : Controller
    {
        NoteService noteService = new NoteService();
        Exeptions exeption = new Exeptions();
        Queries<Note> queries = new Queries<Note>();

        [HttpPost(nameof(NoteInsert))]
        public IActionResult NoteInsert(Note model)
        {
            var result = noteService.InsertRequest(model);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);

        }

        [HttpPut(nameof(NoteUptade))]
        public IActionResult NoteUptade(Note model)
        {
            model.Midterm = Extensions.CheckNumberIsNull(model.Midterm) ? noteService.NoteGetByIdRequest(model.NotesId).Midterm : model.Midterm;
            model.Final = Extensions.CheckNumberIsNull(model.Final) ? noteService.NoteGetByIdRequest(model.NotesId).Final : model.Final;
            model.Average = Extensions.CheckNumberIsNull(model.Average) ? noteService.NoteGetByIdRequest(model.NotesId).Average : model.Average;
            model.StudentId = Extensions.CheckNumberIsNull(model.StudentId) ? noteService.NoteGetByIdRequest(model.NotesId).StudentId : model.StudentId;

            var result = noteService.UpdateRequest(model);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete(nameof(NoteDelete))]
        public IActionResult NoteDelete(int id)
        {
            var result = noteService.NoteDeleteRequest(id);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(NoteGetAll))]
        public IActionResult NoteGetAll()
        {
            var result = noteService.NoteGetAllRequest();

            if (result == null)
            {
                return NotFound(exeption.EmptyTable());
            }
            return Ok(result);
        }

        [HttpGet(nameof(NoteGetById))]
        public IActionResult NoteGetById(int id)
        {
            var result = noteService.GetByIdRequest(id);
            if (result == null)
            {
                return NotFound(exeption.IsNotExistIdExeption());
            }
            return Ok(result);
        }

    }
}
