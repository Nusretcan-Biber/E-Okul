using Businnes;
using Businnes.Model_Services;
using Core.ExeptionControl;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityExample.Controllers
{
    public class StudentController : Controller
    {
        StudentService studentService = new StudentService();
        Exeptions exeption = new Exeptions();

        [HttpPost(nameof(StudentCreate))]
        public IActionResult StudentCreate(Student model)
        {
            var result = studentService.StudentInsertRequest(model);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut(nameof(StudentUpdate))]
        public IActionResult StudentUpdate(Student model)
        {
            model.StudentName  =string.IsNullOrEmpty(model.StudentName) ? studentService.StudentGetByIdRequest(model.SudentId).StudentName : model.StudentName;

            model.StudentSurname= string.IsNullOrEmpty(model.StudentSurname) ? studentService.StudentGetByIdRequest(model.SudentId).StudentSurname : model.StudentSurname;

            var result = studentService.StudentUpdateRequest(model);

            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete(nameof(StudentDelete))]
        public IActionResult StudentDelete(int id) 
        {
            var result = studentService.StudentDeleteRequest(id);
            if (result != exeption.SuccessExeption())
            {
                return BadRequest(result);
            }
            return Ok(result);

        }
        [HttpGet(nameof(StudentGetAll))]
        public IActionResult StudentGetAll()
        {
            var result= studentService.StudentGetAllRequest();

            if (result == null)
            {
                return NotFound(exeption.EmptyTable()) ;
            }
            return Ok(result);
          
          

        }

        [HttpGet(nameof(StudentGetById))]
        public IActionResult StudentGetById(int id)
        {
            var result = studentService.StudentGetByIdRequest(id);
            if(result == null)
            {
                return NotFound(exeption.IsNotExistIdExeption());
            }
            return Ok(result);
        }
     
    }
}
