using Businnes.Model_Services;
using Core.ExeptionControl;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityExample.Controllers
{
    public class LessonController : Controller
    {
        LessonService lessonService= new LessonService();
        Exeptions exeption = new Exeptions();

        [HttpPost(nameof(LessonInsert))]
        public IActionResult LessonInsert(Lesson model)
        {
            var result = lessonService.LessonInsertRequest(model);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut(nameof(LessonUpdate))]
        public IActionResult LessonUpdate(Lesson model)
        {
            model.lessonName = string.IsNullOrEmpty(model.lessonName) ? lessonService.LessonGetByIdRequest(model.lessonId).lessonName : model.lessonName;


            var result = lessonService.LessonUpdateRequest(model);

            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete(nameof(LessonDelete))]
        public IActionResult LessonDelete(int id)
        {
            var result = lessonService.LessonDeleteRequest(id);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);

        }
        [HttpGet(nameof(LessonGetAll))]
        public IActionResult LessonGetAll()
        {
            var result = lessonService.GetAllListRequest();

            if (result == null)
            {
                return NotFound(exeption.EmptyTable());
            }
            return Ok(result);



        }

        [HttpGet(nameof(LessonGetById))]
        public IActionResult LessonGetById(int id)
        {
            var result = lessonService.LessonGetByIdRequest(id);
            if (result == null)
            {
                return NotFound(exeption.IsNotExistIdExeption());
            }
            return Ok(result);
        }
    }
}
