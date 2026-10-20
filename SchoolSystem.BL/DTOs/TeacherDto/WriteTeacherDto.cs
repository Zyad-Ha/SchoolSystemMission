using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.DTOs.TeacherDto
{
    public class WriteTeacherDto
    {
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public int SubjectId { get; set; }
    }
}
