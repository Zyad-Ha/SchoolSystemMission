using SchoolSystem.BL.DTOs.TeacherDto;
using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.DTOs.StudentDto
{
    public class ReadStudentDto
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public List<ReadTeacherDto> Teachers { get; set; }
        public int LaptopId { get; set; }
    }
}
