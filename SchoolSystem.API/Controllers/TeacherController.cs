using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.BL.DTOs.TeacherDto;
using SchoolSystem.BL.Services.TeacherServices;

namespace SchoolSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;
        public TeacherController(ITeacherService teacherService)
        {
            _service = teacherService;
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add(WriteTeacherDto writeTeacherDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            _service.Add(writeTeacherDto);
            return Ok();
        }
    }
}
