using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.BL.DTOs.StudentDto;
using SchoolSystem.BL.Services.StudentServices;

namespace SchoolSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var ok = _studentService.GetAll();
            if (!ok.Any()) return NotFound("No Students added yet");

            return Ok(ok);  
        }

        [HttpPost]
        public ActionResult Add(WriteStudentDto writeStudentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();                             
            }
            _studentService.Add(writeStudentDto);
            return Ok(writeStudentDto);
        }

        [HttpPut]
        public ActionResult Update(int id, WriteStudentDto writeStudentDto)
        {
            try
            {
                _studentService.Update(id, writeStudentDto);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
