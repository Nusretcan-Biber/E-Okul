using Businnes.Model_Services;
using Core.ExeptionControl;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityExample.Controllers
{
    public class TeacherController : Controller
    {
        TeacherService teacherService = new TeacherService();
        Exeptions exeption = new Exeptions();

        [HttpPost(nameof(TeacherInsert))]
        public IActionResult TeacherInsert(Teacher model)
        {
            var result = teacherService.TeacherInsertRequest(model);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut(nameof(TeacherUpdate))]
        public IActionResult TeacherUpdate(Teacher model)
        {
            model.teacherName = string.IsNullOrEmpty(model.teacherName) ? teacherService.GetByIdRequest(model.teacherId).teacherName : model.teacherName;

            model.teacherSurname = string.IsNullOrEmpty(model.teacherSurname) ? teacherService.GetByIdRequest(model.teacherId).teacherSurname : model.teacherSurname;

            model.teacherEmail = string.IsNullOrEmpty(model.teacherEmail) ? teacherService.GetByIdRequest(model.teacherId).teacherEmail : model.teacherEmail;

            model.teacherPassword = string.IsNullOrEmpty(model.teacherPassword) ? teacherService.GetByIdRequest(model.teacherId).teacherPassword : model.teacherPassword;

            var result = teacherService.UpdateRequest(model);

            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete(nameof(TeacherDelete))]
        public IActionResult TeacherDelete(int id)
        {
            var result = teacherService.DeleteRequest(id);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);

        }
        [HttpGet(nameof(TeacherGetAll))]
        public IActionResult TeacherGetAll()
        {
            var result = teacherService.GetAllListRequest();

            if (result == null)
            {
                return NotFound(exeption.EmptyTable());
            }
            return Ok(result);



        }

        [HttpGet(nameof(TeacherGetById))]
        public IActionResult TeacherGetById(int id)
        {
            var result = teacherService.TeacherGetByIdRequest(id);
            if (result == null)
            {
                return NotFound(exeption.IsNotExistIdExeption());
            }
            return Ok(result);
        }
    }
}
