using SchoolSystem.BL.DTOs.TeacherDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services.TeacherServices
{
    public interface ITeacherService
    {
        ReadTeacherDto GetById(int id);
        void Add(WriteTeacherDto writeTeacherDto);
    }
}
