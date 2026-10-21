using SchoolSystem.BL.DTOs.StudentDto;
using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services.StudentServices
{
    public interface IStudentService
    {
        IEnumerable<ReadStudentDto> GetAll();
        void Add(WriteStudentDto studentDto);
        void Update(int id,UpdateStudentDto studentDto);
        void Delete(int id);

    }
}
