using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.BL.DTOs.SubjectDto;
using SchoolSystem.BL.Services.SubjectServices;

namespace SchoolSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpPost]
        public ActionResult Add(WriteSubjectDto writeSubjectDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            _subjectService.Add(writeSubjectDto);
            return Ok("Subject added successfully");
        }
    }
}
