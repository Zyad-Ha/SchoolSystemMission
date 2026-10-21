using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SchoolSystem.BL.DTOs.StudentDto
{
    public class WriteStudentDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public List<int> TeacherIds { get; set; }
        public int LaptopId { get; set; }
    }
}
