using SchoolSystem.BL.DTOs.SubjectDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services.SubjectServices
{
    public interface ISubjectService
    {
        void Add(WriteSubjectDto writeSubjectDto);
    }
}
